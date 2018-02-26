using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Gather_Klient
{
    public class custom_font
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
          IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private PrivateFontCollection fonts = new PrivateFontCollection();

        public custom_font()
        {

            byte[] fontData = Properties.Resources.OpenSans_Regular;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.OpenSans_Regular.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.OpenSans_Regular.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            fontData = Properties.Resources.OpenSans_Semibold;
            fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.OpenSans_Semibold.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.OpenSans_Semibold.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);
            

        }


        public Font load_font(float size, int bold_level, bool open_sans)
        {
            try
            {
                if (open_sans)
                {
                    switch (bold_level)
                    {
                        case 0:
                            return new Font(fonts.Families[0], size);
                        case 1:
                            return new Font(fonts.Families[1], size);
                        case 2:
                            return new Font(fonts.Families[1], size, FontStyle.Bold);
                    }
                }

                return new Font(fonts.Families[0], size);
            } catch
            {
                return new Font(fonts.Families[0], size);
            }
           
        }




    }
}
