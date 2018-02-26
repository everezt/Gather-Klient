using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Gather_Klient
{
    public partial class warmup_scr : Form
    {        

        public List<warmup_server> servers = new List<warmup_server>();
        csgo_server_status server_network = new csgo_server_status();
        custom_font c_font = new custom_font();
        custom_messagebox c_msgbox = new custom_messagebox();
        private string warmup_server_ip = "";
        private int currently_active_server = 0;

        public warmup_scr()
        {       
            InitializeComponent();

            // load font to display items
            current_server_name_label.Font = c_font.load_font(21, 1, true);
            players_in_current_server_label.Font = c_font.load_font(14, 1, true);
            current_server_map_label.Font = c_font.load_font(14, 1, true);
            current_server_location_label.Font = c_font.load_font(14, 1, true);

            map_pool_label.Font = c_font.load_font(21, 1, true);
            current_server_map_pool_label.Font = c_font.load_font(14, 1, true);

            warmup_servers_grid.DefaultCellStyle.Font = c_font.load_font(10, 1, true);
        }

        public void force_grid_bg_update()
        {
            warmup_servers_grid.does_bg_need_refresh = true;
        }

        private void join_btn_MouseEnter(object sender, EventArgs e)
        {
            join_btn.BackgroundImage = Properties.Resources.join_btn_inactive;
        }

        private void join_btn_MouseLeave(object sender, EventArgs e)
        {
            join_btn.BackgroundImage = Properties.Resources.join_btn_active;
        }

        private void join_btn_Click(object sender, EventArgs e)
        {
            Process.Start("steam://connect/" + warmup_server_ip);
        }

        private void copy_ip_btn_MouseEnter(object sender, EventArgs e)
        {
            copy_ip_btn.BackgroundImage = Properties.Resources.copy_ip_btn_inactive;
        }

        private void copy_ip_btn_MouseLeave(object sender, EventArgs e)
        {
            copy_ip_btn.BackgroundImage = Properties.Resources.copy_ip_btn_active;
        }

        private void copy_ip_btn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("connect " + warmup_server_ip);
            c_msgbox.show_msg(false, "Kopeeritud!");
        }

        public void refresh_servers(object obj, EventArgs e)
        {
            for (int i = 0; i <= servers.Count - 1; i++)
            {
                warmup_server temp_serv = servers[i];
                server_network.update_status(ref temp_serv);
                servers[i] = temp_serv;

                for (int j = 0; j <= warmup_servers_grid.Rows.Count -1; j++)
                {
                    
                    if (int.Parse(warmup_servers_grid.Rows[j].Cells[4].Value.ToString()) == servers[i].Id)
                    {
                        warmup_servers_grid.does_bg_need_refresh = true;
                        warmup_servers_grid.Rows[j].Cells[0].Value = servers[i].Name;
                        warmup_servers_grid.Rows[j].Cells[1].Value = servers[i].Map;                       
                        warmup_servers_grid.Rows[j].Cells[2].Value = servers[i].Players;
                       
                    }
                }

                if (servers[i].Id == currently_active_server)
                {
                    current_server_name_label.Text = servers[i].Name;
                    players_in_current_server_label.Text = servers[i].Players;
                    current_server_map_label.Text = servers[i].Map;
                }
            }

           

        }


        private void warmup_scr_Load(object sender, EventArgs e)
        {

            refresh_servers(sender, e);
                       
           for (int i = 0; i <= servers.Count -1; i++)
            {
                warmup_servers_grid.Rows.Add(servers[i].Name, servers[i].Map, servers[i].Players, servers[i].Ip + ":" + servers[i].Port.ToString(), servers[i].Id);
            }


            for (int i = 0; i <= warmup_servers_grid.Rows.Count -1; i++)
            {
                warmup_servers_grid.Rows[i].MinimumHeight = 38;
            }

            warmup_server_ip = servers[0].Ip + ":" + servers[0].Port.ToString();

            current_server_name_label.Text = servers[0].Name;
            players_in_current_server_label.Text = servers[0].Players;
            current_server_map_label.Text = servers[0].Map;
        }


        private void warmup_servers_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            warmup_server_ip = warmup_servers_grid.Rows[e.RowIndex].Cells[3].Value.ToString();

            current_server_name_label.Text = warmup_servers_grid.Rows[e.RowIndex].Cells[0].Value.ToString();
            current_server_map_label.Text = warmup_servers_grid.Rows[e.RowIndex].Cells[1].Value.ToString();
            players_in_current_server_label.Text = warmup_servers_grid.Rows[e.RowIndex].Cells[2].Value.ToString();
            currently_active_server = Convert.ToInt16(warmup_servers_grid.Rows[e.RowIndex].Cells[4].Value.ToString());

            if (e.RowIndex == 0)
            {
                current_server_map_pool_label.Text = "aim_map\naim_warmup\naim_redline\naim_usp";
            }
            else
            {
                current_server_map_pool_label.Text = "Klassikalised mapid\nde_inferno\nde_season";
            }
        }
    }
}
