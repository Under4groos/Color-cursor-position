using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewForm.lib
{
    static class ScreenLib
    {
        public static int CountScreen()
        {
            return Screen.AllScreens.Length;
        }
        public static Size GetScreenSize()
        {
            return Screen.PrimaryScreen.Bounds.Size;
        }
        public static Color GetColorPixel( Point P )
        {
            Bitmap Bitmap_ = new Bitmap(1, 1);
            Rectangle Rectangle_ = new Rectangle(P.X, P.Y, 1, 1);
            Graphics g = Graphics.FromImage(Bitmap_);
            g.CopyFromScreen(Rectangle_.Location, Point.Empty, Rectangle_.Size);
            return Bitmap_.GetPixel(0, 0);
        }


        public static bool isEqualColor( this Color C , Color C2)
        {

            return
                C.R == C2.R &&
                C.G == C2.G &&
                C.B == C2.B ;
        }



    }


}
