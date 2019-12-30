using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyacinth.Controls.Drawing
{
    public sealed class HyacinthPalette
    {
        public static Color GetStyleColor(HyacinthColorStyle style)
        {
            switch (style)
            {
                case HyacinthColorStyle.Black:
                    return HyacinthColors.Black;
                case HyacinthColorStyle.White:
                    return HyacinthColors.White;
                default:
                    return HyacinthColors.Blue;
            }
        }
    }
}
