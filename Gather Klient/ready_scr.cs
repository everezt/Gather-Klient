using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Gather_Klient
{
    public partial class ready_scr : Form
    {
        main_hub_scr main_hub;

        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        delegate void string_delegate(string text);
        delegate void func_delegate();

        public ready_scr(main_hub_scr ref_main_hub)
        {            
            InitializeComponent();
            main_hub = ref_main_hub;
            //player_1_ready.AccessibleDescription = "TERE TERE";
        }

        private void ready_btn_MouseEnter(object sender, EventArgs e)
        {
            ready_btn.BackgroundImage = Properties.Resources.ready_btn_inactive;
        }

        private void ready_btn_MouseLeave(object sender, EventArgs e)
        {
            ready_btn.BackgroundImage = Properties.Resources.ready_btn_active;
        }

        public void update_ready_time(string secs)
        {
            if (InvokeRequired)
            {
                string_delegate d = new string_delegate(update_ready_time);
                this.Invoke(d, new object[] { secs });
            }
            else
            {
                timeleft.Text = "Aega jäänud: " + secs + "s";

                if (!main_hub.my_info.am_i_ready)
                {
                    // play sound
                    SoundPlayer beep = new SoundPlayer(Properties.Resources.beep);
                    beep.Play();
                }
            }
          
        }

        public void im_ready()
        {
            if(InvokeRequired)
            {
                func_delegate d = new func_delegate(im_ready);
                this.Invoke(d, new object[] { });
            } else
            {
                ready_btn.Enabled = false;
                ready_btn.BackgroundImage = Properties.Resources.ready_btn_inactive;
                main_hub.my_info.am_i_ready = true;
            }
           
        }

        private void ready_btn_Click(object sender, EventArgs e)
        {
            List<string> ready_packet = new List<string>();
            ready_packet.Add(main_hub.my_info.s_hash.ToString());
            ready_packet.Add(main_hub.my_info.lobby_id.ToString());
            main_hub.shared_udpclient.send_data(0x06, ready_packet);

        }

        private void ready_scr_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragging = true;  // _dragging is your variable flag
                _start_point = new Point(e.X, e.Y);
            }
        }

        private void ready_scr_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragging = false;
            }
        }

        private void ready_scr_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
    }
}
