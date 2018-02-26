using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;

namespace Gather_Klient
{
    public partial class main_hub_scr : Form
    {

        // delegates
        delegate void bool_delegate(bool is_alive);
        delegate void string_delegate(string text);
        delegate void func_delegate();
        delegate void int_delegate(int number);

        // networking
        static network udpclient;
        public network shared_udpclient;

        // main variables
        /* active_screen
         * 0 - home
         * 1 - play
         * 2 - warmup
         * 3 - stats
         * 4 - play -> lobby
         * 5 - stats -> etc
         */
        int active_screen = 0;
        int last_screen = 0;

        bool is_server_alive = true;

        // listener thread
        Thread listener_thread;

        // user info
        public me my_info = new me();

        // Timers
        System.Windows.Forms.Timer keep_alive = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer server_alive = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer update_warmup_servers = new System.Windows.Forms.Timer();

        // Profile picture painter
        profile_pic_painter prof_pic_painter = new profile_pic_painter();

        // custom messagebox
        custom_messagebox c_msgbox = new custom_messagebox();

        // custom fonts
        custom_font c_font = new custom_font();

        // screens
        home_scr home_screen = new home_scr();
        play_scr play_screen; // set in class init
        warmup_scr warmup_screen = new warmup_scr();
        stats_scr stats_screen = new stats_scr();
        update_prof_pic_scr update_prof_pic_screen;
        lobby_scr lobby_screen;
        login_scr login_screen;
        ready_scr ready_screen;

        // screen to be movable
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);




        

        public main_hub_scr(login_scr r_login, network r_udpclient)
        {
            InitializeComponent();

           

            // send prof pic request
            List<string> prof_pic_req_packet = new List<string>();
            prof_pic_req_packet.Add(r_login.steamid);
            r_udpclient.send_data(0x27, prof_pic_req_packet);

            // transfer refrences
            login_screen = r_login;
            udpclient = r_udpclient;
            shared_udpclient = r_udpclient;

            // set playscreen ref
            play_screen = new play_scr(this);

            // set lobby screen ref
            lobby_screen = new lobby_scr(this);

            // set ready screen ref
            ready_screen = new ready_scr(this);

            // load fonts
            username_label.Font = c_font.load_font(20, 1, true);
            

            // initialize packet listener thread
            listener_thread = new Thread(new ThreadStart(manage_packets));
            listener_thread.Start();




            // USER STUFF
            // load profile picture
            //paint_my_profile_picture("asd");
            my_info.steamid = login_screen.steamid;
            my_info.username = login_screen.get_username();
            my_info.s_hash = login_screen.s_hash;

            // Update labels
            username_label.Text = my_info.username;



            // add screens to screen panel

            // home screen
            keep_alive_tick(this, new EventArgs());
            home_screen.TopLevel = false;
            home_screen.AutoScroll = false;
            screen_panel.Controls.Add(home_screen);
            home_screen.Show();

            // play screen
            play_screen.TopLevel = false;
            play_screen.AutoScroll = false;
            screen_panel.Controls.Add(play_screen);

            // warmup screen
            warmup_screen.TopLevel = false;
            warmup_screen.AutoScroll = false;
            screen_panel.Controls.Add(warmup_screen);
            warmup_screen.servers.Add(new warmup_server("212.49.20.161", 27015, 0));
            warmup_screen.servers.Add(new warmup_server("212.49.20.163", 27015, 1));
            warmup_screen.servers.Add(new warmup_server("212.49.20.163", 27025, 2));
            warmup_screen.servers.Add(new warmup_server("212.49.20.163", 27035, 3));
            warmup_screen.servers.Add(new warmup_server("212.49.20.163", 27045, 4));
            

            // stats screen
            stats_screen.TopLevel = false;
            stats_screen.AutoScroll = false;
            screen_panel.Controls.Add(stats_screen);

            // lobby screen
            lobby_screen.TopLevel = false;
            lobby_screen.AutoScroll = false;
            screen_panel.Controls.Add(lobby_screen);

            // initialize timers
            keep_alive.Interval = 2000; // 2 sec
            keep_alive.Tick += new EventHandler(keep_alive_tick);
            keep_alive.Start();

            server_alive.Interval = 30000; // 30 sec
            server_alive.Tick += new EventHandler(check_server_alive);
            server_alive.Start();

            update_warmup_servers.Interval = 10000;
            update_warmup_servers.Tick += new EventHandler(warmup_screen.refresh_servers);
            update_warmup_servers.Start();
        }

        void stop_timers()
        {
            if(InvokeRequired)
            {
                func_delegate d = new func_delegate(stop_timers);
                this.Invoke(d, new object[] { });
            }
            else
            {                               
                keep_alive.Stop();
                server_alive.Stop();
            }           
        }

        public void paint_my_profile_picture(string url)
        {
            if(InvokeRequired)
            {
                string_delegate d = new string_delegate(paint_my_profile_picture);
                this.Invoke(d, new object[] { url });
            }
            else
            {
                Task.Run(new Action(() => { prof_pic_main.Image = prof_pic_painter.paint_profile_image(url, false, false); }));
            }
            
        }
        
        public void update_prof_pic(string url)
        {
            List<string> update_prof_pic_packet = new List<string>();
            update_prof_pic_packet.Add(my_info.s_hash.ToString());
            update_prof_pic_packet.Add(url);
            udpclient.send_data(0x26, update_prof_pic_packet);
            paint_my_profile_picture(url);
        }

        void logout()
        {
            if (InvokeRequired)
            {
                func_delegate d = new func_delegate(logout);
                this.Invoke(d, new object[] {});
            }
            else
            {
                if (listener_thread.IsAlive)
                {
                    listener_thread.Abort();
                }
                stop_timers();
                login_screen.Show();
                this.Close();
            }
            
        }

        void check_server_alive(object obj, EventArgs e)
        {
            if (!is_server_alive)
            {
                logout();
                c_msgbox.show_msg(false, "Ühendus serveriga on aegunud!");
            }
            else
            {
                is_server_alive = false;
            }
        }

        void keep_alive_tick(object obj, EventArgs e)
        {
            List<string> alive_packet = new List<string>();
            alive_packet.Add(my_info.s_hash.ToString());
            alive_packet.Add(my_info.steamid);

            // alive packet
            if(!udpclient.send_data(0x01, alive_packet))
            {
                c_msgbox.show_msg(true,"Paketi saatmine serverisse ebaõnnestus!");
                logout();

            }

            // users online packet
            if (!udpclient.send_data(0x08, alive_packet))
            {
                c_msgbox.show_msg(true, "Paketi saatmine serverisse ebaõnnestus!");
                logout();

            }

            // get list of users online
            if (!udpclient.send_data(0x25, alive_packet))
            {
                c_msgbox.show_msg(true, "Paketi saatmine serverisse ebaõnnestus!");
                logout();

            }

            if(!udpclient.send_data(0x03, alive_packet))
            {
                c_msgbox.show_msg(true, "Paketi saatmine serverisse ebaõnnestus!");
                logout();
            }
        }

        private void update_server_alive(bool is_alive)
        {
            if (this.InvokeRequired)
            {
                bool_delegate d = new bool_delegate(update_server_alive);
                this.Invoke(d, new object[] { is_alive });
            }
            else
            {
                this.is_server_alive = is_alive;
            }
        }


        void refresh_buttons()
        {
            switch (active_screen)
            {
                case 0: // home screen
                    home_btn.BackgroundImage = Properties.Resources.home_btn_active;
                    play_btn.BackgroundImage = Properties.Resources.play_btn_inactive;
                    warmup_btn.BackgroundImage = Properties.Resources.warmup_btn_inactive;
                    stats_btn.BackgroundImage = Properties.Resources.stats_btn_inactive;
                    break;
                case 1: // play screen
                    home_btn.BackgroundImage = Properties.Resources.home_btn_inactive;
                    play_btn.BackgroundImage = Properties.Resources.play_btn_active;
                    warmup_btn.BackgroundImage = Properties.Resources.warmup_btn_inactive;
                    stats_btn.BackgroundImage = Properties.Resources.stats_btn_inactive;
                    break;
                case 2: // warmup screen
                    home_btn.BackgroundImage = Properties.Resources.home_btn_inactive;
                    play_btn.BackgroundImage = Properties.Resources.play_btn_inactive;
                    warmup_btn.BackgroundImage = Properties.Resources.warmup_btn_active;
                    stats_btn.BackgroundImage = Properties.Resources.stats_btn_inactive;
                    break;
                case 3: // stats screen
                    home_btn.BackgroundImage = Properties.Resources.home_btn_inactive;
                    play_btn.BackgroundImage = Properties.Resources.play_btn_inactive;
                    warmup_btn.BackgroundImage = Properties.Resources.warmup_btn_inactive;
                    stats_btn.BackgroundImage = Properties.Resources.stats_btn_active;
                    break;
                case 4:
                    home_btn.BackgroundImage = Properties.Resources.home_btn_inactive;
                    play_btn.BackgroundImage = Properties.Resources.play_btn_active;
                    warmup_btn.BackgroundImage = Properties.Resources.warmup_btn_inactive;
                    stats_btn.BackgroundImage = Properties.Resources.stats_btn_inactive;
                    break;
            }
        }

        

        private void manage_packets()
        {
            while (true)
            {
                byte[] packet = udpclient.listen();

                byte cmd = packet[0];

                if (cmd != 0x17)
                {
                    switch (cmd)
                    {
                        case 0x01:
                            if (packet[1] == 0xFA)
                            {
                                stop_timers(); // Stops timers and threads
                                c_msgbox.show_msg(false, "Server on sinu ühenduse katkestanud!");
                                logout();                               
                            }
                            else
                            {
                                List<string> me_live_info = udpclient.extract_data(packet);
                                // me_live_info[0] - stored client hash
                                // me_live_info[1] - is_client_in_lobby
                                // me_live_info[2] - lobby id
                                // me_live_info[3] - lobby status
                                // me_live_info[4] - am i ready
                                if (my_info.s_hash == long.Parse(me_live_info[0]))
                                {
                                    if (me_live_info[1] == "in_lobby")
                                    {
                                        my_info.am_i_in_lobby = true;
                                        //MessageBox.Show("IN LOBBY");
                                        play_screen.allow_leave_button();

                                        if (me_live_info[3] == "Live" || me_live_info[3] == "Veto")
                                        {
                                            play_screen.disable_both_buttons();
                                            if (!my_info.lobby_window_open)
                                            {
                                                //change to active lobby screen
                                                change_screen(4);
                                            }
                                        }

                                        if (me_live_info[4] == "not_ready")
                                        {
                                            my_info.am_i_ready = false;
                                        }
                                        else
                                        {
                                            my_info.am_i_ready = true;
                                        }

                                        if (me_live_info[3] == "Ready-up")
                                        {
                                            if(!my_info.ready_window_open)
                                            {
                                                //open ready screenr
                                                my_info.ready_window_open = true;
                                                open_ready_screen();
                                                if (my_info.am_i_ready)
                                                {
                                                    ready_screen.im_ready();
                                                }
                                            }
                                        }

                                        my_info.lobby_id = int.Parse(me_live_info[2]);
                                        my_info.lobby_status = me_live_info[3];
                                    }
                                    else
                                    {
                                        my_info.am_i_in_lobby = false;
                                        play_screen.allow_join_button();

                                        if (my_info.ready_window_open)
                                        {
                                            //close ready window
                                        }

                                        if (my_info.lobby_window_open)
                                        {
                                            //close lobby window
                                            if (active_screen == 4)
                                            {
                                                change_screen(1);
                                            }
                                        }
                                    }

                                   
                                }
                                update_server_alive(true);
                            }                                                   
                            break;
                        case 0x03:
                            List<lobby> lobbies = new List<lobby>();
                            List<string> data = udpclient.extract_data(packet);
                            /*
                             * 0 - lobbies count
                             * 1 - [i]lobby name
                             * 2 - [i]lobby status
                             * 3 - [i]lobby map
                             * 4 - [i]lobby players
                             * 5 - [i]lobby score
                             * 6 - [i]lobby avg_elo
                             * 7 - [i]lobby id
                             */
                            int offset = 1;
                            for(int i = 0; i <= int.Parse(data[0]) -1; i++)
                            {
                                lobby temp_lobby = new lobby();
                                temp_lobby.name = data[offset];
                                temp_lobby.status = data[offset + 1];
                                temp_lobby.map = data[offset + 2];
                                temp_lobby.players = data[offset + 3];
                                temp_lobby.score = data[offset + 4];
                                if (data[offset +5] == "-nan")
                                {
                                    temp_lobby.avg_elo = "-";
                                }
                                else
                                {
                                    temp_lobby.avg_elo = Math.Round(float.Parse(data[offset + 5], CultureInfo.InvariantCulture.NumberFormat), 3).ToString();
                                }
                                
                                temp_lobby.id = int.Parse(data[offset + 6]);
                                lobbies.Add(temp_lobby);
                                offset += 7;
                            }

                            play_screen.update_lobby_list(lobbies);
                            break;
                        case 0x05:
                            if (packet[1] == 0x01)
                            {
                                // you're already in lobby
                                c_msgbox.show_msg(false, "Sa oled juba kuskil lobbis!");
                            }

                            if (packet[1] == 0x02)
                            {
                                //lobby is full 
                                c_msgbox.show_msg(false, "See lobby on täis!");
                            }

                            if (packet[1] == 0x03)
                            {
                                // lobby does not accept players
                                c_msgbox.show_msg(false, "See lobby ei võta enam uusi mängijaid vastu!");
                            }

                            if (packet[1] == 0xFF)
                            {
                                // success
                                play_screen.allow_leave_button();
                                //c_msgbox.show_msg(false, "Sa liitusid lobbiga!");
                            }
                            break;
                        case 0x06:
                            //ready
                            if (packet[1] == 0xFF)
                            {
                                ready_screen.im_ready();
                            }
                            break;
                        case 0x08:
                            home_screen.update_clients_online_numer(udpclient.extract_data(packet)[0]);
                            break;
                        case 0x09:
                            List<string> players_data = udpclient.extract_data(packet);
                            play_screen.show_players(players_data[0], players_data[1]);
                            break;
                        case 0x10:
                            // leave lobby
                            if (packet[1] == 0x01)
                            {
                                // Player is actually not in lobby
                            }

                            if(packet[1] == 0x02)
                            {
                                // You cannot leave lobby anymore
                            }

                            if(packet[1] == 0x03)
                            {
                                // You are not in THIS lobby
                            }

                            if(packet[1] == 0xFF)
                            {
                                my_info.am_i_in_lobby = false;
                                my_info.am_i_ready = false;
                                play_screen.allow_join_button();
                                c_msgbox.show_msg(false, "Sa lahkusid lobbist!");
                            }
                            break;
                        case 0x11:
                            // update ready time
                            //MessageBox.Show("timeleft: " + udpclient.extract_data(packet)[0]);
                            ready_screen.update_ready_time(udpclient.extract_data(packet)[0]);
                            break;
                        case 0x12:
                            // notice 0x01 - open ready screen
                            // 0x02 - You failed to ready up
                            if (packet[1] == 0x01)
                            {
                                my_info.ready_window_open = true;
                                open_ready_screen();
                            }

                            if (packet[1] == 0x02)
                            {
                                if (my_info.ready_window_open)
                                {
                                    close_ready_screen();
                                    c_msgbox.show_msg(false, "Sa ei jõudnud valmis vajutada!");
                                }
                            }
                            break;
                        case 0x25:
                            home_screen.update_clients_list(udpclient.extract_data(packet));
                            break;
                        case 0x27:
                            paint_my_profile_picture(udpclient.extract_data(packet)[0]);
                            break;
                    }
                }
                Thread.Sleep(1);
            }
        }

        private void open_ready_screen()
        {
            if (InvokeRequired)
            {
                func_delegate d = new func_delegate(open_ready_screen);
                this.Invoke(d, new object[] {  });
            }
            else
            {
                if (ready_screen == null)
                {
                    ready_screen = new ready_scr(this);
                }

                if (ready_screen.IsDisposed)
                {
                    ready_screen = new ready_scr(this);
                }
                ready_screen.Show();
                ready_screen.TopMost = true;
            }
        }

        private void close_ready_screen()
        {
            if (InvokeRequired)
            {
                func_delegate d = new func_delegate(close_ready_screen);
                this.Invoke(d, new object[] { });
            }
            else
            {
                ready_screen.Close();
            }
        }

        private void change_screen(int new_screen)
        {

            if (InvokeRequired)
            {
                int_delegate d = new int_delegate(change_screen);
                this.Invoke(d, new object[] { new_screen });
            }
            else
            {
                int curr_screen = active_screen;



                switch (new_screen)
                {
                    case 0:
                        home_screen.Show();
                        active_screen = new_screen;
                        break;
                    case 1:
                        play_screen.force_grid_bg_update();
                        play_screen.Show();
                        active_screen = new_screen;
                        break;
                    case 2:
                        warmup_screen.force_grid_bg_update();
                        warmup_screen.Show();
                        active_screen = new_screen;
                        break;
                    case 3:
                        stats_screen.Show();
                        active_screen = new_screen;
                        break;
                    case 4:
                        my_info.lobby_window_open = true;
                        lobby_screen.Show();
                        active_screen = new_screen;
                        break;
                }

                refresh_buttons();

                switch (curr_screen)
                {
                    case 0:
                        home_screen.Hide();
                        last_screen = curr_screen;
                        break;
                    case 1:
                        play_screen.Hide();
                        last_screen = curr_screen;
                        break;
                    case 2:
                        warmup_screen.Hide();
                        last_screen = curr_screen;
                        break;
                    case 3:
                        stats_screen.Hide();
                        last_screen = curr_screen;
                        break;
                    case 4:
                        lobby_screen.Hide();
                        last_screen = curr_screen;
                        break;
                }
            }
            
        }

        private void play_btn_MouseEnter(object sender, EventArgs e)
        {
            //c_msgbox.show_msg(false, "Curr screen: " + active_screen.ToString());
            if (active_screen != 1  && active_screen != 4)
            {
                play_btn.BackgroundImage = Properties.Resources.play_btn_active;
            }
        }

        private void play_btn_MouseLeave(object sender, EventArgs e)
        {
            if (active_screen != 1 && active_screen != 4)
            {
                play_btn.BackgroundImage = Properties.Resources.play_btn_inactive;
            }
        }

        private void warmup_btn_MouseEnter(object sender, EventArgs e)
        {
            if (active_screen != 2)
            {
                warmup_btn.BackgroundImage = Properties.Resources.warmup_btn_active;
            }
        }

        private void warmup_btn_MouseLeave(object sender, EventArgs e)
        {
            if (active_screen != 2)
            {
                warmup_btn.BackgroundImage = Properties.Resources.warmup_btn_inactive;
            }
        }

        private void stats_btn_MouseEnter(object sender, EventArgs e)
        {
            if (active_screen != 3)
            {
                stats_btn.BackgroundImage = Properties.Resources.stats_btn_active;
            }
        }

        private void stats_btn_MouseLeave(object sender, EventArgs e)
        {
            if (active_screen != 3)
            {
                stats_btn.BackgroundImage = Properties.Resources.stats_btn_inactive;
            }
        }

        private void home_btn_MouseEnter(object sender, EventArgs e)
        {
            if (active_screen != 0)
            {
                home_btn.BackgroundImage = Properties.Resources.home_btn_active;
            }
        }

        private void home_btn_MouseLeave(object sender, EventArgs e)
        {
            if (active_screen != 0)
            {
                home_btn.BackgroundImage = Properties.Resources.home_btn_inactive;
            }
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            if (active_screen != 1)
            {
                if (my_info.am_i_in_lobby && (my_info.lobby_status == "Live" || my_info.lobby_status == "Veto"))
                {
                    change_screen(4);
                }
                else
                {
                    change_screen(1);
                }
                
            }
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            if (active_screen != 0)
            {
                change_screen(0);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            // login screen is parent to this form, so closing that will close both
            listener_thread.Abort();
            login_screen.Close();
        }

        private void custom_button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void warmup_btn_Click(object sender, EventArgs e)
        {
            if (active_screen != 2)
            {
                change_screen(2);
            }
        }

        private void stats_btn_Click(object sender, EventArgs e)
        {
            if (active_screen != 3)
            {
                change_screen(3);
            }
        }

        private void main_hub_scr_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragging = true;  // _dragging is your variable flag
                _start_point = new Point(e.X, e.Y);
            }
        }

        private void main_hub_scr_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragging = false;
            }
        }

        private void main_hub_scr_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void btn_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragging = true;  // _dragging is your variable flag
                _start_point = new Point(e.X, e.Y);
            }
        }

        private void btn_panel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragging = false;
            }
        }

        private void btn_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void prof_pic_main_MouseClick(object sender, MouseEventArgs e)
        {
            if (update_prof_pic_screen == null)
            {
                update_prof_pic_screen = new update_prof_pic_scr(this);
            }

            if (update_prof_pic_screen.IsDisposed)
            {
                update_prof_pic_screen = new update_prof_pic_scr(this);
                update_prof_pic_screen.Show();
            }
            else
            {
                update_prof_pic_screen.Show();
            }
        }

        private void main_hub_scr_Resize(object sender, EventArgs e)
        {
            play_screen.force_grid_bg_update();
            warmup_screen.force_grid_bg_update();
        }

        private void username_label_Click(object sender, EventArgs e)
        {
           // ready_screen.ShowDialog();
        }
    }
}
