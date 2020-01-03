using Hyacinth.Controls.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyacinth.Controls
{
    internal static class HyacinthBrushes
    {
        private static readonly Dictionary<string, SolidBrush> hyacinthBrushes = new Dictionary<string, SolidBrush>();

        private static SolidBrush GetSaveBrush(string key, Color color)
        {
            lock (HyacinthBrushes.hyacinthBrushes)
            {
                if (!HyacinthBrushes.hyacinthBrushes.TryGetValue(key, out SolidBrush solidBrush))
                {
                    solidBrush = new SolidBrush(color);
                    HyacinthBrushes.hyacinthBrushes.Add(key, solidBrush);
                }
                return (SolidBrush)solidBrush.Clone();
            }
        }

        public static SolidBrush Black
        {
            get
            {
                return HyacinthBrushes.GetSaveBrush(nameof(Black), HyacinthColors.Black);
            }
        }

        public static SolidBrush White
        {
            get
            {
                return HyacinthBrushes.GetSaveBrush(nameof(White), HyacinthColors.White);
            }
        }

        public static SolidBrush Silver
        {
            get
            {
                return HyacinthBrushes.GetSaveBrush(nameof(Silver), HyacinthColors.Silver);
            }
        }

        public static SolidBrush Blue
        {
            get
            {
                return HyacinthBrushes.GetSaveBrush(nameof(Blue), HyacinthColors.Blue);
            }
        }

        public static SolidBrush Green
        {
            get
            {
                return HyacinthBrushes.GetSaveBrush(nameof(Green), HyacinthColors.Green);
            }
        }

        public static SolidBrush Lime
        {
            get
            {
                return HyacinthBrushes.GetSaveBrush(nameof(Lime), HyacinthColors.Lime);
            }
        }

        public static SolidBrush Teal
        {
            get
            {
                return HyacinthBrushes.GetSaveBrush(nameof(Teal), HyacinthColors.Teal);
            }
        }

        public static SolidBrush Orange
        {
            get
            {
                return HyacinthBrushes.GetSaveBrush(nameof(Orange), HyacinthColors.Orange);
            }
        }

        public static SolidBrush Brown
        {
            get
            {
                return HyacinthBrushes.GetSaveBrush(nameof(Brown), HyacinthColors.Brown);
            }
        }

        public static SolidBrush Pink
        {
            get
            {
                return HyacinthBrushes.GetSaveBrush(nameof(Pink), HyacinthColors.Pink);
            }
        }

        public static SolidBrush Magenta
        {
            get
            {
                return HyacinthBrushes.GetSaveBrush(nameof(Magenta), HyacinthColors.Magenta);
            }
        }

        public static SolidBrush Purple
        {
            get
            {
                return HyacinthBrushes.GetSaveBrush(nameof(Purple), HyacinthColors.Purple);
            }
        }

        public static SolidBrush Red
        {
            get
            {
                return HyacinthBrushes.GetSaveBrush(nameof(Red), HyacinthColors.Red);
            }
        }

        public static SolidBrush Yellow
        {
            get
            {
                return HyacinthBrushes.GetSaveBrush(nameof(Yellow), HyacinthColors.Yellow);
            }
        }
    }
}
