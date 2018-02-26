using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Gather_Klient
{
    public class profile_pic_painter
    {
        public Image paint_profile_image(string prof_pic_link, bool is_lobby, bool is_alternating)
        {
            PictureBox temp_picbox = new PictureBox();

            try
            {
                if (!is_lobby)
                {  
                    temp_picbox.Load(prof_pic_link);
                    int scale_substraction = 2;
                    for ( int i = 0; i <= 99; i++)
                    {
                        if (temp_picbox.Image.Size.Height / scale_substraction < 100)
                        {
                            scale_substraction--;
                            break;
                        }

                        if (temp_picbox.Image.Size.Width / scale_substraction < 100)
                        {
                            scale_substraction--;
                            break;
                        }
                       
                            scale_substraction++;
                        
                    }
                    Image img = (Image)(new Bitmap(temp_picbox.Image, temp_picbox.Image.Width / scale_substraction, temp_picbox.Image.Height / scale_substraction));
                    using (Graphics g = Graphics.FromImage(img))
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.DrawEllipse(new Pen(Color.WhiteSmoke, 64), new Rectangle(-25, -25, 150, 150));
                        g.DrawEllipse(new Pen(Color.FromArgb(56, 145, 221), 60), new Rectangle(-25, -25, 150, 150));

                    }
                    temp_picbox.Dispose();
                    return img;
                }
                else
                {
                    temp_picbox.Load(prof_pic_link);

                    Image img = (Image)(new Bitmap(temp_picbox.Image, 50, 50));
                    using (Graphics g = Graphics.FromImage(img))
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.DrawEllipse(new Pen(Color.WhiteSmoke, 42), new Rectangle(-12, -12, 75, 75));
                        if (is_alternating)
                        {
                            g.DrawEllipse(new Pen(Color.FromArgb(38, 38, 40), 40), new Rectangle(-12, -12, 75, 75));
                        }
                        else
                        {
                            g.DrawEllipse(new Pen(Color.FromArgb(49, 49, 51), 40), new Rectangle(-12, -12, 75, 75));
                        }
                        temp_picbox.Dispose();
                        return img;
                    }
                }
            }
            catch (Exception ex)
            {

                if (!is_lobby)
                {
                   
                    Image img = (Image)(new Bitmap(Properties.Resources.unknown_prof_pic, 100, 100));
                    using (Graphics g = Graphics.FromImage(img))
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.DrawEllipse(new Pen(Color.WhiteSmoke, 64), new Rectangle(-25, -25, 150, 150));
                        g.DrawEllipse(new Pen(Color.FromArgb(56, 145, 221), 60), new Rectangle(-25, -25, 150, 150));

                    }
                    temp_picbox.Dispose();
                    return img;
                }
                else
                {
                    Image img = (Image)(new Bitmap(Properties.Resources.unknown_prof_pic, 50, 50));
                    using (Graphics g = Graphics.FromImage(img))
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.DrawEllipse(new Pen(Color.WhiteSmoke, 42), new Rectangle(-12, -12, 75, 75));
                        if (is_alternating)
                        {
                            g.DrawEllipse(new Pen(Color.FromArgb(38, 38, 40), 40), new Rectangle(-12, -12, 75, 75));
                        }
                        else
                        {
                            g.DrawEllipse(new Pen(Color.FromArgb(49, 49, 51), 40), new Rectangle(-12, -12, 75, 75));
                        }
                        temp_picbox.Dispose();
                        return img;
                    }
                }
            }
        }
    }
}
