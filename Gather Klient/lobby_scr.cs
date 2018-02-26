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
    public partial class lobby_scr : Form
    {
        main_hub_scr main_hub_screen;
        public lobby_scr(main_hub_scr ref_main_hub_scr)
        {
            InitializeComponent();
            main_hub_screen = ref_main_hub_scr;
        }
    }
}
