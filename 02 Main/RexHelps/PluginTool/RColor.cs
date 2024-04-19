using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RexHelps
{
    public class RColor
    {
        public static string ToHexColor(Color color)
        {
            string R = Convert.ToString(color.R, 16) == "0" ? "00" : Convert.ToString(color.R, 16);
            string G = Convert.ToString(color.G, 16) == "0" ? "00" : Convert.ToString(color.G, 16);
            string B = Convert.ToString(color.B, 16) == "0" ? "00" : Convert.ToString(color.B, 16);
            return "#" + R + G + B;
        }
    }
}
