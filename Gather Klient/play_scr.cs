using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gather_Klient
{
    public partial class play_scr : Form
    {
        custom_font c_font = new custom_font();

        delegate void update_lobbies_delegate(List<lobby> lobbies);
        delegate void show_players_delegate(string players_a, string players_b);
        delegate void func_delegate();

        int current_active_lobby_id = 1;
        int curr_button_mode = 1; // 1 - join allowed, 2 - leave allowed, 3 - both disabled

        List<lobby> current_lobbies = new List<lobby>();

        main_hub_scr main_hub;

        public play_scr(main_hub_scr ref_main_hub)
        {
            InitializeComponent();

            main_hub = ref_main_hub;

            play_lobby_grid.DefaultCellStyle.Font = c_font.load_font(10, 1, true);

            //play_lobby_grid.Rows.Add("PREVIEW #1", "Vaba", "Pole valitud", "0/10", "0 - 0", "-", 0);
            //play_lobby_grid.Rows.Add("PREVIEW #2", "Vaba", "Pole valitud", "0/10", "0 - 0", "-", 1);
            //play_lobby_grid.Rows.Add("PREVIEW #3", "Vaba", "Pole valitud", "0/10", "0 - 0", "-", 2);
            //play_lobby_grid.Rows.Add("PREVIEW #4", "Vaba", "Pole valitud", "0/10", "0 - 0", "-", 3);

            for (int i = 0; i <= play_lobby_grid.Rows.Count - 1; i++)
            {
                play_lobby_grid.Rows[i].MinimumHeight = 38;
            }
        }

        void update_lobby_labels(lobby c_lobby)
        {
            lobby_name.Text = c_lobby.name;
            lobby_map.Text = c_lobby.map;
            lobby_players.Text = c_lobby.players;
            lobby_score.Text = c_lobby.score;
            lobby_status.Text = c_lobby.status;

            if (c_lobby.status == "Live" || c_lobby.status == "Ready-up" || c_lobby.status == "Veto")
            {
                List<string> get_players = new List<string>();
                get_players.Add(current_active_lobby_id.ToString());
                main_hub.shared_udpclient.send_data(0x09, get_players);
            }
            else
            {
                team_a_label.Visible = false;
                team_b_label.Visible = false;
                team_a_players.Visible = false;
                team_b_players.Visible = false;
            }
        }

        public void show_players(string players_a, string players_b)
        {
            if(InvokeRequired)
            {
                show_players_delegate d = new show_players_delegate(show_players);
                this.Invoke(d, new object[] { players_a, players_b });
            }
            else
            {
                team_a_players.Text = players_a;
                team_b_players.Text = players_b;

                team_a_label.Visible = true;
                team_b_label.Visible = true;
                team_a_players.Visible = true;
                team_b_players.Visible = true;
            }
        }

        public void update_lobby_list(List<lobby> lobbies)
        {
          
            if (InvokeRequired)
            {
                update_lobbies_delegate d = new update_lobbies_delegate(update_lobby_list);
                this.Invoke(d, new object[] { lobbies });
            }
            else
            {
                current_lobbies = lobbies;

                if (play_lobby_grid.RowCount == 0)
                {
                    for (int i = 0; i <= lobbies.Count - 1; i++)
                    {
                        if(current_active_lobby_id == lobbies[i].id)
                        {
                            update_lobby_labels(lobbies[i]);                          
                        }
                        play_lobby_grid.Rows.Add(lobbies[i].name, lobbies[i].status, lobbies[i].map, lobbies[i].players, lobbies[i].score, lobbies[i].avg_elo, lobbies[i].id);
                        force_grid_bg_update();
                        play_lobby_grid.Rows[play_lobby_grid.RowCount - 1].MinimumHeight = 34;
                        
                    }
                }
                else
                {
                    bool found_lobby = false;
                    for (int i = 0; i <= lobbies.Count - 1; i++)
                    {
                        if (current_active_lobby_id == lobbies[i].id)
                        {
                            update_lobby_labels(lobbies[i]);                           
                        }

                        for (int j = 0; j <= play_lobby_grid.RowCount - 1; j++)
                        {
                            if (int.Parse(play_lobby_grid.Rows[j].Cells[6].Value.ToString()) == lobbies[i].id)
                            {
                                play_lobby_grid.Rows[j].Cells[0].Value = lobbies[i].name;
                                play_lobby_grid.Rows[j].Cells[1].Value = lobbies[i].status;
                                play_lobby_grid.Rows[j].Cells[2].Value = lobbies[i].map;
                                play_lobby_grid.Rows[j].Cells[3].Value = lobbies[i].players;
                                play_lobby_grid.Rows[j].Cells[4].Value = lobbies[i].score;
                                force_grid_bg_update();
                                play_lobby_grid.Rows[j].Cells[5].Value = lobbies[i].avg_elo;
                            }
                            found_lobby = true;
                            continue;
                        }

                        if (!found_lobby)
                        {
                            play_lobby_grid.Rows.Add(lobbies[i].name, lobbies[i].status, lobbies[i].map, lobbies[i].players, lobbies[i].score, lobbies[i].avg_elo, lobbies[i].id);
                            force_grid_bg_update();
                            play_lobby_grid.Rows[play_lobby_grid.RowCount - 1].MinimumHeight = 34;

                        }
                    }
                }
            }         
        }

        public void force_grid_bg_update()
        {
            play_lobby_grid.does_bg_need_refresh = true;
        }

        private void join_btn_MouseEnter(object sender, EventArgs e)
        {
            if (join_btn.Enabled)
            {
                join_btn.BackgroundImage = Properties.Resources.join_btn_inactive;
            }
        }

        private void join_btn_MouseLeave(object sender, EventArgs e)
        {
            if (join_btn.Enabled)
            {
                join_btn.BackgroundImage = Properties.Resources.join_btn_active;
            }
        }

        private void leave_btn_MouseEnter(object sender, EventArgs e)
        {
            if(leave_btn.Enabled)
            {
                leave_btn.BackgroundImage = Properties.Resources.leave_btn_inactive;
            }
        }

        private void leave_btn_MouseLeave(object sender, EventArgs e)
        {
            if (leave_btn.Enabled)
            {
                leave_btn.BackgroundImage = Properties.Resources.leave_btn_active;
            }
        }

        private void play_lobby_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int clicked_lobby_id = int.Parse(play_lobby_grid.Rows[e.RowIndex].Cells[6].Value.ToString());

            if (clicked_lobby_id != current_active_lobby_id)
            {
                current_active_lobby_id = clicked_lobby_id;

                for(int i = 0; i <= current_lobbies.Count -1; i++)
                {
                    if (current_lobbies[i].id == current_active_lobby_id)
                    {
                        update_lobby_labels(current_lobbies[i]);
                        break;
                    }
                }
            }
        }

        public void allow_leave_button()
        {
            if (InvokeRequired)
            {
                func_delegate d = new func_delegate(allow_leave_button);
                this.Invoke(d, new object[] { });
            }
            else
            {
                if (curr_button_mode != 2)
                {
                    join_btn.Enabled = false;
                    leave_btn.Enabled = true;

                    // graphics
                    join_btn.BackgroundImage = Properties.Resources.join_btn_inactive;
                    leave_btn.BackgroundImage = Properties.Resources.leave_btn_active;

                    curr_button_mode = 2;
                }
            }            
        }

        public void allow_join_button()
        {
            if (InvokeRequired)
            {
                func_delegate d = new func_delegate(allow_join_button);
                this.Invoke(d, new object[] { });
            }
            else
            {
                if (curr_button_mode != 1)
                {
                    join_btn.Enabled = true;
                    leave_btn.Enabled = false;

                    // graphics
                    join_btn.BackgroundImage = Properties.Resources.join_btn_active;
                    leave_btn.BackgroundImage = Properties.Resources.leave_btn_inactive;

                    curr_button_mode = 1;
                }
            }
        }

        public void disable_both_buttons()
        {
            if (InvokeRequired)
            {
                func_delegate d = new func_delegate(disable_both_buttons);
                this.Invoke(d, new object[] { });
            }
            else
            {
                if (curr_button_mode != 3)
                {

                    join_btn.Enabled = false;
                    leave_btn.Enabled = false;

                    // graphics
                    join_btn.BackgroundImage = Properties.Resources.join_btn_inactive;
                    leave_btn.BackgroundImage = Properties.Resources.leave_btn_inactive;

                    curr_button_mode = 3;
                }
            }
        }

        private void join_btn_Click(object sender, EventArgs e)
        {
            List<string> join_data = new List<string>();
            join_data.Add(main_hub.my_info.s_hash.ToString());
            join_data.Add(current_active_lobby_id.ToString());
            main_hub.shared_udpclient.send_data(0x05, join_data);
        }

        private void leave_btn_Click(object sender, EventArgs e)
        {
            if (main_hub.my_info.lobby_id != -1)
            {
                List<string> leave_data = new List<string>();
                leave_data.Add(main_hub.my_info.s_hash.ToString());
                leave_data.Add(main_hub.my_info.lobby_id.ToString());
                main_hub.shared_udpclient.send_data(0x10, leave_data);
            }
            
        }
    }
}
