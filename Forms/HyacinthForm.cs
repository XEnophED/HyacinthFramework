using Hyacinth.Controls.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hyacinth.Controls.Forms
{
    public class HyacinthForm : Form
    {
        private HyacinthBorderStyle _borderStyle;
        private bool isResizable = true;

        [DefaultValue(HyacinthBorderStyle.None)]
        [Browsable(true)]
        [Category("Hyacinth Appearance")]
        public HyacinthBorderStyle BorderStyle
        {
            get
            {
                return this._borderStyle;
            }
            set
            {
                this._borderStyle = value;
            }
        }

        [Category("Hyacinth Appearance")]
        public bool Resizable
        {
            get
            {
                return this.isResizable;
            }
            set
            {
                this.isResizable = value;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Color color = HyacinthPalette.BackColor.Form(HyacinthThemeStyle.Default);
            Color foreColor = HyacinthPalette.ForeColor.Form(HyacinthThemeStyle.Default);
            e.Graphics.Clear(color);
            using (SolidBrush styleBrush = HyacinthPalette.GetStyleBrush(HyacinthColorStyle.Black))
            {
                Rectangle rect = new Rectangle(0, 0, this.Width, 5);
                e.Graphics.FillRectangle((Brush)styleBrush, rect);
            }
            if (this.BorderStyle != HyacinthBorderStyle.None)
            {
                using (Pen pen = new Pen(HyacinthPalette.BorderColor.Form(HyacinthThemeStyle.Default)))
                    e.Graphics.DrawLines(pen, new Point[4]
                    {
                        new Point(0, 5),
                        new Point(0, this.Height - 1),
                        new Point(this.Width - 1, this.Height - 1),
                        new Point(this.Width - 1, 5)
                    });
            }
            //if (!this.displayHeader)
            //    return;
            //TextRenderingHint textRenderingHint = e.Graphics.TextRenderingHint;
            //e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            SmoothingMode smoothingMode = e.Graphics.SmoothingMode;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            //Rectangle bounds = new Rectangle(20, 20, this.ClientRectangle.Width - 40, 40);
            //TextFormatFlags flags = TextFormatFlags.EndEllipsis | this.GetTextFormatFlags();
            //TextRenderer.DrawText((IDeviceContext)e.Graphics, this.Text, MetroFonts.Title, bounds, foreColor, flags);
            //e.Graphics.TextRenderingHint = textRenderingHint;
            e.Graphics.SmoothingMode = smoothingMode;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (!this.Resizable || this.SizeGripStyle != SizeGripStyle.Auto && this.SizeGripStyle != SizeGripStyle.Show)
                return;
            using (SolidBrush solidBrush = new SolidBrush(HyacinthPalette.ForeColor.Button.Disabled(HyacinthThemeStyle.Dark)))
            {
                Size size = new Size(2, 2);
                e.Graphics.FillRectangles((Brush)solidBrush, new Rectangle[6]
                {
                  new Rectangle(new Point(this.ClientRectangle.Width - 6, this.ClientRectangle.Height - 6), size),
                  new Rectangle(new Point(this.ClientRectangle.Width - 10, this.ClientRectangle.Height - 10), size),
                  new Rectangle(new Point(this.ClientRectangle.Width - 10, this.ClientRectangle.Height - 6), size),
                  new Rectangle(new Point(this.ClientRectangle.Width - 6, this.ClientRectangle.Height - 10), size),
                  new Rectangle(new Point(this.ClientRectangle.Width - 14, this.ClientRectangle.Height - 6), size),
                  new Rectangle(new Point(this.ClientRectangle.Width - 6, this.ClientRectangle.Height - 14), size)
                });
            }
        }
    }
}
