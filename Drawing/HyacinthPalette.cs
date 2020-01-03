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

        public static SolidBrush GetStyleBrush(HyacinthColorStyle style)
        {
            switch (style)
            {
                case HyacinthColorStyle.Black:
                    return HyacinthBrushes.Black;
                case HyacinthColorStyle.White:
                    return HyacinthBrushes.White;
                default:
                    return HyacinthBrushes.Blue;
            }
        }
        public sealed class BackColor
        {
            public static Color Form(HyacinthThemeStyle theme)
            {
                return theme == HyacinthThemeStyle.Dark ? Color.FromArgb(17, 17, 17) : Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
            }

            public sealed class Button
            {
                public static Color Normal(HyacinthThemeStyle theme)
                {
                    return theme == HyacinthThemeStyle.Dark ? Color.FromArgb(34, 34, 34) : Color.FromArgb(238, 238, 238);
                }

                public static Color Hover(HyacinthThemeStyle theme)
                {
                    return theme == HyacinthThemeStyle.Dark ? Color.FromArgb(170, 170, 170) : Color.FromArgb(102, 102, 102);
                }

                public static Color Press(HyacinthThemeStyle theme)
                {
                    return theme == HyacinthThemeStyle.Dark ? Color.FromArgb(238, 238, 238) : Color.FromArgb(51, 51, 51);
                }

                public static Color Disabled(HyacinthThemeStyle theme)
                {
                    return theme == HyacinthThemeStyle.Dark ? Color.FromArgb(80, 80, 80) : Color.FromArgb(204, 204, 204);
                }
            }   
        }
        public sealed class BorderColor
        {
            public static Color Form(HyacinthThemeStyle theme)
            {
                return theme == HyacinthThemeStyle.Dark ? Color.FromArgb(153, 153, 153) : Color.FromArgb(153, 153, 153);
            }

            public static class Button
            {
                public static Color Normal(HyacinthThemeStyle theme)
                {
                    return theme == HyacinthThemeStyle.Dark ? Color.FromArgb(68, 68, 68) : Color.FromArgb(204, 204, 204);
                }

                public static Color Hover(HyacinthThemeStyle theme)
                {
                    return theme == HyacinthThemeStyle.Dark ? Color.FromArgb(170, 170, 170) : Color.FromArgb(102, 102, 102);
                }

                public static Color Press(HyacinthThemeStyle theme)
                {
                    return theme == HyacinthThemeStyle.Dark ? Color.FromArgb(238, 238, 238) : Color.FromArgb(51, 51, 51);
                }

                public static Color Disabled(HyacinthThemeStyle theme)
                {
                    return theme == HyacinthThemeStyle.Dark ? Color.FromArgb(109, 109, 109) : Color.FromArgb(155, 155, 155);
                }
            }
        }
        public sealed class ForeColor
        {
            public static Color Form(HyacinthThemeStyle theme)
            {
                return theme == HyacinthThemeStyle.Dark ? Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue) : Color.FromArgb(0, 0, 0);
            }

            public sealed class Button
            {
                public static Color Normal(HyacinthThemeStyle theme)
                {
                    return theme == HyacinthThemeStyle.Dark ? Color.FromArgb(204, 204, 204) : Color.FromArgb(0, 0, 0);
                }

                public static Color Hover(HyacinthThemeStyle theme)
                {
                    return theme == HyacinthThemeStyle.Dark ? Color.FromArgb(17, 17, 17) : Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                }

                public static Color Press(HyacinthThemeStyle theme)
                {
                    return theme == HyacinthThemeStyle.Dark ? Color.FromArgb(17, 17, 17) : Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                }

                public static Color Disabled(HyacinthThemeStyle theme)
                {
                    return theme == HyacinthThemeStyle.Dark ? Color.FromArgb(109, 109, 109) : Color.FromArgb(136, 136, 136);
                }
            }

            public sealed class Tile
            {
                public static Color Normal(HyacinthThemeStyle theme)
                {
                    return theme == HyacinthThemeStyle.Dark ? Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue) : Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                }

                public static Color Hover(HyacinthThemeStyle theme)
                {
                    return theme == HyacinthThemeStyle.Dark ? Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue) : Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                }

                public static Color Press(HyacinthThemeStyle theme)
                {
                    return theme == HyacinthThemeStyle.Dark ? Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue) : Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                }

                public static Color Disabled(HyacinthThemeStyle theme)
                {
                    return theme == HyacinthThemeStyle.Dark ? Color.FromArgb(209, 209, 209) : Color.FromArgb(209, 209, 209);
                }
            }
        }
    }
}
