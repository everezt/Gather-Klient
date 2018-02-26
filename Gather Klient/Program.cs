using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;

namespace Gather_Klient
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new login_scr());
        }
      
    }

   

    public class custom_button : Button
    {
        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }

        protected override Cursor DefaultCursor
        {
            get
            {
                return Cursors.Hand;
            }
        }

    }

    public class custom_label : Label
    {
        protected override Cursor DefaultCursor
        {
            get
            {
                return Cursors.Hand;
            }
        }
    }

    public class warmup_datagridview : DataGridView
    {
        public bool does_bg_need_refresh = true;


        protected override void PaintBackground(Graphics graphics, Rectangle clipBounds, Rectangle gridBounds)
        {
            
             base.PaintBackground(graphics, clipBounds, gridBounds);          

            if (does_bg_need_refresh)
            {
                Rectangle bg_rect = new Rectangle(0, 0, this.Width, this.Height);
                graphics.DrawImageUnscaledAndClipped(Properties.Resources.warmup_grid_bg, bg_rect);
                does_bg_need_refresh = false;
            }

        }   
    }

    public class play_datagridview : DataGridView
    {
        public bool does_bg_need_refresh = true;

        protected override void PaintBackground(Graphics graphics, Rectangle clipBounds, Rectangle gridBounds)
        {
            base.PaintBackground(graphics, clipBounds, gridBounds);

            if (does_bg_need_refresh)
            {
                Rectangle bg_rect = new Rectangle(0, 0, this.Width, this.Height);
                graphics.DrawImageUnscaledAndClipped(Properties.Resources.play_grid_bg, bg_rect);
                does_bg_need_refresh = false;
            }

        }
    }

   
}
