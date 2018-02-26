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
    public partial class update_prof_pic_scr : Form
    {
        main_hub_scr main_hub_screen;
        custom_font c_font = new custom_font();
        public update_prof_pic_scr(main_hub_scr ref_hub)
        {
            main_hub_screen = ref_hub;
            InitializeComponent();
            url_input.Font = c_font.load_font(12, 1, true);
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void url_input_Enter(object sender, EventArgs e)
        {
            if (url_input.Text == "URL")
            {
                url_input.Text = "";
                url_input.ForeColor = Color.WhiteSmoke;
            }
        }

        private void url_input_Leave(object sender, EventArgs e)
        {
            if (url_input.Text == "")
            {
                url_input.Text = "URL";
                url_input.ForeColor = Color.FromArgb(108, 108, 108);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (url_input.Text.Contains("http://") || url_input.Text.Contains("https://"))
            {
                if (url_input.Text.Contains(".jpg") || url_input.Text.Contains(".jpeg") || url_input.Text.Contains(".png"))
                {
                    main_hub_screen.update_prof_pic(url_input.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sisestatud link ei sobi profiilipildiks!");
                }
            }
        }

    }
}
