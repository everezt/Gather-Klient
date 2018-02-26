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
using System.Security.Cryptography;
using Microsoft.Win32;
using System.Management;
using System.Globalization;

namespace Gather_Klient
{
    public partial class login_scr : Form
    {

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        public string steamid;
        public long s_hash;

        custom_font c_fonts = new custom_font();
        custom_messagebox c_msgbox = new custom_messagebox();
        

        public login_scr()
        {
            InitializeComponent();

            
            //csd_centered

            // Load fonts to display items
            username_input.Font = c_fonts.load_font(18, 3, true);
            password_input.Font = c_fonts.load_font(18, 3, true);
            version_label.Font = c_fonts.load_font(8, 1, true);
            reg_btn.Font = c_fonts.load_font(15, 1, true);
            info_btn.Font = c_fonts.load_font(15, 1, true);

            // Update version label
            version_label.Text = Properties.Settings.Default.version.ToString();
        }

        private bool am_i_up_to_date()
        {
            try
            {
                System.Net.WebClient ver_checker = new System.Net.WebClient();

                float newest_ver = float.Parse(ver_checker.DownloadString("http://csgo.ee/g_client/ver.txt"), CultureInfo.InvariantCulture.NumberFormat);

                if (newest_ver > Properties.Settings.Default.version)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                return true;
            }

        }

        private void try_login()
        {
            try
            {
                if (username_input.Text == "")
                {
                    throw new Exception("Sisesta kasutajanimi");
                }

                if (password_input.Text == "")
                {
                    throw new Exception("Sisesta parool");
                }

                network udpcon = new network();

                if (udpcon.connect_to_server())
                {

                    // Get sha512 password
                    string sha512_password = "";

                    if (Properties.Settings.Default.remember_me)
                    {
                        sha512_password = Properties.Settings.Default.sha512_pw;
                    }
                    else
                    {
                        UnicodeEncoding UE = new UnicodeEncoding();
                        byte[] message = UE.GetBytes(password_input.Text);
                        SHA512Managed hashString = new SHA512Managed();

                        byte[] hashValue = hashString.ComputeHash(message);
                        foreach (byte x in hashValue)
                        {
                            sha512_password += String.Format("{0:x2}", x);
                        }
                    }


                    // Let's start building the packet
                    List<string> login_packet = new List<string>();
                    string version = Properties.Settings.Default.version.ToString();
                    //Clipboard.SetText(sha512_password);
                    if (version.Contains(","))
                    {
                        version = version.Replace(',', '.');
                    }

                    login_packet.Add(username_input.Text.ToLower());
                    login_packet.Add(sha512_password);

                    login_packet.Add(version);
                    login_packet.Add(get_hw_id());

                    // Send login packet and recieve response
                    byte[] login_response = udpcon.send_and_recieve(0x02, login_packet);

                    if (login_response[0] == 0xFA)
                    {
                        // we have failed login attempt
                        switch (login_response[1])
                        {
                            case 0x01:
                                throw new Exception("Tundmatu veateade!");
                            case 0x02:
                                throw new Exception("Sinu kliendi versioon on liiga vana!");
                            case 0x03:
                                throw new Exception("Vale kasutajanimi või parool!");
                            case 0x04:
                                throw new Exception("Kasutaja on juba sisse loginud. Juhul kui Sinu ühendus aegus, oota 2min!");
                            case 0x05:
                                List<string> ban_info = udpcon.extract_data(login_response);
                                throw new Exception("Sa oled banned.\nPõhjus: " + ban_info[0] + "\nKestab kuni: " + ban_info[1]);
                            case 0x06:
                                throw new Exception("Serveriga ühenduse loomine ebaõnnestus!");
                        }
                    }

                    if (login_response[0] == 0xFF)
                    {
                        // Login was successful
                        List<string> recieved_data = udpcon.extract_data(login_response);
                        steamid = recieved_data[0];
                        string password = recieved_data[1];
                        s_hash = long.Parse(recieved_data[2]);

                        if (password != sha512_password)
                        {
                            List<string> abuse_data = new List<string>();
                            abuse_data.Add("Passwords do not match at user-side after getting 'ok'");
                            //main_client.send_data(0x16, abuseData);
                        }
                        else
                        {
                            if (remember_me.Checked)
                            {
                                string keyName = @"HKEY_CURRENT_USER\SOFTWARE\everest\Gather";
                                Registry.SetValue(keyName, "username", username_input.Text);
                                Registry.SetValue(keyName, "password", sha512_password);
                                Registry.SetValue(keyName, "remember_me", true);
                            }
                            else
                            {
                                string keyName = @"HKEY_CURRENT_USER\SOFTWARE\everest\Gather";
                                Registry.SetValue(keyName, "username", "");
                                Registry.SetValue(keyName, "password", "");
                                Registry.SetValue(keyName, "remember_me", false);
                            }

                            // initialize new window and give refrence to connection and this form
                            main_hub_scr main_window = new main_hub_scr(this,udpcon);
                            main_window.Show();
                            this.Hide();
                            //throw new Exception("LOGIN OK");
                        }
                    }

                    //c_msgbox.show_msg(false, "See funktsioon ei ole valmis veel!\nSinu hw_id: " + get_hw_id());

                }
                else
                {
                    c_msgbox.show_msg(true, "Serveriga ühenduse loomine ebaõnnestus!");
                }

            }
            catch (Exception ex)
            {
                c_msgbox.show_msg(true, ex.Message);
            }

        }

        public string get_hw_id()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                result += Convert.ToString(strt["VolumeSerialNumber"]);
            }
            return result;
        }

        private void login_btn_MouseEnter(object sender, EventArgs e)
        {
            login_btn.BackgroundImage = Properties.Resources.login_btn_inactive;
        }

        private void login_btn_MouseLeave(object sender, EventArgs e)
        {
            login_btn.BackgroundImage = Properties.Resources.login_btn_active;
        }

        private void password_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                login_btn.PerformClick();
            }

        }

        private void username_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                login_btn.PerformClick();
            }
        }

        private void info_btn_MouseClick(object sender, MouseEventArgs e)
        {
            Process.Start("http://csgo.ee");
        }

        private void close_btn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void reg_btn_MouseClick(object sender, MouseEventArgs e)
        {
            // open reg window
            reg_scr register_screen = new reg_scr();
            register_screen.ShowDialog();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try_login();
            
        }

        private void login_scr_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragging = true;  // _dragging is your variable flag
                _start_point = new Point(e.X, e.Y);
            }
        }

        private void login_scr_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragging = false;
            }
        }

        private void login_scr_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

       

        private void login_scr_Shown(object sender, EventArgs e)
        {
            string keyName = @"HKEY_CURRENT_USER\SOFTWARE\everest\Gather";
            if (Registry.GetValue(keyName, "remember_me", null) != null)
            {
                username_input.Text = Registry.GetValue(keyName, "username", "").ToString();
                password_input.Text = Registry.GetValue(keyName, "username", "").ToString();
                remember_me.Checked = Convert.ToBoolean(Registry.GetValue(keyName, "remember_me", ""));
                password_input.Select(0, 0);

                Properties.Settings.Default.username = Registry.GetValue(keyName, "username", "").ToString();
                Properties.Settings.Default.sha512_pw = Registry.GetValue(keyName, "password", "").ToString();
                Properties.Settings.Default.remember_me = Convert.ToBoolean(Registry.GetValue(keyName, "remember_me", ""));
            }

            if (!am_i_up_to_date())
            {
                login_btn.Enabled = false;
                c_msgbox.show_msg(false, "Klient vajab uuendust, vajuta OK kui oled valmis uuendama");
                //do_update();
            }
        }

        public string get_username()
        {
            return username_input.Text;
        }

        private void remember_me_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_btn.PerformClick();
            }
        }

        public void close_me()
        {
            this.Close();
        }

    }   
}
