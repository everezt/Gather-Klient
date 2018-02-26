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
    public partial class custom_messagebox : Form
    {

        // delegate
        private delegate void show_msg_delegate(bool is_error, string text);

        // custom font
        custom_font c_font = new custom_font();

        public custom_messagebox()
        {
            InitializeComponent();
            msg_text.Font = c_font.load_font(12, 1, true);
        }

        public void show_msg(bool is_error, string text)
        {
            if (this.InvokeRequired)
            {
                show_msg_delegate d = new show_msg_delegate(show_msg);
                this.Invoke(d, new object[] { is_error, text });
            }
            else
            {
                if (is_error)
                {
                    this.Text = "ERROR";
                }
                else
                {
                    this.Text = "Teade";
                }

                msg_text.Text = text;

                if (this.Visible)
                {
                    this.Close();
                }
               
                this.ShowDialog();

                
            }
            
        }

        private void ok_btn_MouseEnter(object sender, EventArgs e)
        {
            ok_btn.BackgroundImage = Properties.Resources.ok_btn_inactive;
        }

        private void ok_btn_MouseLeave(object sender, EventArgs e)
        {
            ok_btn.BackgroundImage = Properties.Resources.ok_btn_active;
        }

        private void ok_btn_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
