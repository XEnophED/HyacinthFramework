using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyacinth.Controls.Drawing
{
    internal static class HyacinthColors
    {
        public static Color Black
        {
            get
            {
                return Color.FromArgb(0, 0, 0);
            }
        }

        public static Color White
        {
            get
            {
                return Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
            }
        }

        public static Color Silver
        {
            get
            {
                return Color.FromArgb(85, 85, 85);
            }
        }

        public static Color Blue
        {
            get
            {
                return Color.FromArgb(0, 174, 219);
            }
        }

        public static Color Green
        {
            get
            {
                return Color.FromArgb(0, 177, 89);
            }
        }

        public static Color Lime
        {
            get
            {
                return Color.FromArgb(142, 188, 0);
            }
        }

        public static Color Teal
        {
            get
            {
                return Color.FromArgb(0, 170, 173);
            }
        }

        public static Color Orange
        {
            get
            {
                return Color.FromArgb(243, 119, 53);
            }
        }

        public static Color Brown
        {
            get
            {
                return Color.FromArgb(165, 81, 0);
            }
        }

        public static Color Pink
        {
            get
            {
                return Color.FromArgb(231, 113, 189);
            }
        }

        public static Color Magenta
        {
            get
            {
                return Color.FromArgb((int)byte.MaxValue, 0, 148);
            }
        }

        public static Color Purple
        {
            get
            {
                return Color.FromArgb(124, 65, 153);
            }
        }

        public static Color Red
        {
            get
            {
                return Color.FromArgb(209, 17, 65);
            }
        }

        public static Color Yellow
        {
            get
            {
                return Color.FromArgb((int)byte.MaxValue, 196, 37);
            }
        }
    }
}
