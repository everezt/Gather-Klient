using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.Cryptography;

namespace Gather_Klient
{
    public partial class reg_scr : Form
    {

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        text_checker txt_chk = new text_checker();
        custom_messagebox c_msgbox = new custom_messagebox();
        custom_font c_font = new custom_font();

        public reg_scr()
        {
            InitializeComponent();

            // load fonts to diplay items
            username_input.Font = c_font.load_font(18, 0, true);
            password_input.Font = c_font.load_font(18, 0, true);
            password_repeat_input.Font = c_font.load_font(18, 0, true);
            email_input.Font = c_font.load_font(18, 0, true);
            steamid_input.Font = c_font.load_font(18, 0, true);

            // let's find steamid's user has in his/her registry
            RegistryKey steamUsers = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Valve\Steam\Users");
            List<string> steamIdsFound = new List<string>();
            foreach (string subKeyName in steamUsers.GetSubKeyNames())
            {
                using (RegistryKey
                    tempKey = steamUsers.OpenSubKey(subKeyName))
                {
                    steamIdsFound.Add(tempKey.Name.Split((char)92)[5]);

                }
            }

            for (int i = 0; i <= steamIdsFound.Count - 1; i++)
            {
                double halfId = Int32.Parse(steamIdsFound[i]);
                double calcId = (halfId / 2);
                if (calcId == (int)calcId)
                {
                    steamid_input.Items.Add("STEAM_1:0:" + calcId);
                }
                else
                {
                    steamid_input.Items.Add("STEAM_1:1:" + (int)calcId);
                }
            }
            this.Select();
        }

        private void reg_btn_MouseEnter(object sender, EventArgs e)
        {
            reg_btn.BackgroundImage = Properties.Resources.reg_btn_inactive;
        }

        private void reg_btn_MouseLeave(object sender, EventArgs e)
        {
            reg_btn.BackgroundImage = Properties.Resources.reg_btn_active;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void username_input_Enter(object sender, EventArgs e)
        {
            if (username_input.Text == "Kasutajanimi")
            {
                // make it empty
                username_input.Text = "";
            }
        }

        private void username_input_Leave(object sender, EventArgs e)
        {
            if (txt_chk.is_empty(username_input.Text))
            {
                username_input.Text = "Kasutajanimi";
            }
        }

        private void password_input_Enter(object sender, EventArgs e)
        {
            if (password_input.Text == "Parool")
            {
                password_input.Text = "";
                password_input.PasswordChar = '*';
            }
        }

        private void password_input_Leave(object sender, EventArgs e)
        {
            if (txt_chk.is_empty(password_input.Text))
            {
                password_input.Text = "Parool";
                password_input.PasswordChar = '\0';
            }
        }

        private void password_repeat_input_Enter(object sender, EventArgs e)
        {
            if (password_repeat_input.Text == "Korda")
            {
                password_repeat_input.Text = "";
                password_repeat_input.PasswordChar = '*';
            }
        }

        private void password_repeat_input_Leave(object sender, EventArgs e)
        {
            if (txt_chk.is_empty(password_repeat_input.Text))
            {
                password_repeat_input.Text = "Korda";
                password_repeat_input.PasswordChar = '\0';
            }
        }

        private void email_input_Enter(object sender, EventArgs e)
        {
            if (email_input.Text == "Email")
            {
                email_input.Text = "";
            }
        }

        private void email_input_Leave(object sender, EventArgs e)
        {
            if (txt_chk.is_empty(email_input.Text))
            {
                email_input.Text = "Email";
            }
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            try_register();
        }

        private void try_register()
        {
            try
            {
                if (txt_chk.is_empty(username_input.Text))
                {
                    throw new Exception("Sisestage kasutajanimi!");
                }

                if (txt_chk.is_empty(password_input.Text))
                {
                    throw new Exception("Sisestage parool!");
                }

                if (txt_chk.is_empty(password_repeat_input.Text))
                {
                    throw new Exception("Sisestage kordus parool!");
                }

                if (txt_chk.is_empty(email_input.Text))
                {
                    throw new Exception("Sisestage email!");
                }

                if (txt_chk.is_empty(steamid_input.Text))
                {
                    throw new Exception("Valige menüüst enda steamid!");
                }

                if (password_repeat_input.Text != password_input.Text)
                {
                    throw new Exception("Sisestatud paroolid ei klapi!");
                }

                if (!txt_chk.is_text_aZ09(username_input.Text))
                {
                    throw new Exception("Kasutajanimi tohib sisaldada ainult\n tähti a-Z ja numbreid 0-9!");
                }

                if (!txt_chk.is_email(email_input.Text))
                {
                    throw new Exception("Emaili formaat on ebakorrektne!");
                }


                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] message = UE.GetBytes(password_input.Text);
                SHA512Managed hashString = new SHA512Managed();
                string sha512_password = "";

                byte[] hashValue = hashString.ComputeHash(message);
                foreach (byte x in hashValue)
                {
                    sha512_password += String.Format("{0:x2}", x);
                }

                network udpcon = new network();

                if (udpcon.connect_to_server())
                {
                    List<string> reg_packet = new List<string>();
                    reg_packet.Add(username_input.Text);
                    reg_packet.Add(username_input.Text.ToLower());
                    reg_packet.Add(sha512_password);
                    reg_packet.Add(email_input.Text);
                    reg_packet.Add(steamid_input.Text);

                    byte[] register_response = udpcon.send_and_recieve(0x18, reg_packet);

                    if (register_response[0] == 0xFF)
                    {
                        // successful register
                        c_msgbox.show_msg(false, "Registreerimine õnnestus!");
                        this.Close();
                    }
                    else
                    {
                        // failed to register
                        switch (register_response[1])
                        {
                            case 0x01:
                                throw new Exception("Server ei suutnud registreerimist käsitleda!");
                            case 0x02:
                                throw new Exception("Selline kasutajanimi juba eksisteerib!");
                            case 0x03:
                                throw new Exception("Selline e-mail juba eksisteerib!");
                            case 0x04:
                                throw new Exception("Selline steamid juba eksisteerib!");
                            case 0x06:
                                throw new Exception("Serveriga ühenduse loomine ebaõnnestus!");
                        }
                    }
                }
                else
                {
                    c_msgbox.show_msg(true, "Serveriga ühenduse loomine ebaõnnestus!");
                }


            }
            catch (Exception ex)
            {
                c_msgbox.show_msg(false, ex.Message);
            }
        }

        private void username_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try_register();
            }          
        }

        private void password_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try_register();
            }
        }

        private void password_repeat_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try_register();
            }
        }

        private void email_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try_register();
            }
        }

        private void steamid_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try_register();
            }
        }

        private void reg_scr_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragging = true;  // _dragging is your variable flag
                _start_point = new Point(e.X, e.Y);
            }
        }

        private void reg_scr_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragging = false;
            }
        }

        private void reg_scr_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
    }
}
