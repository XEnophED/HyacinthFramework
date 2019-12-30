using Hyacinth.Controls.Drawing;
using Hyacinth.Controls.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hyacinth.Controls.Usables
{
    [ToolboxBitmap(typeof(System.Windows.Forms.Button))]
    public class HyacinthTile : Button, IContainerControl, IHyacinthControl
    {
        /// <summary>
        /// private variables for control
        /// </summary>
        private Control activeControl;
        private ContentAlignment tileImageAlign = ContentAlignment.TopLeft;
        private bool useCustomBackground;
        private bool useCustomForeColor;
        private bool isHovered;
        private bool isPressed;
        private bool isFocused;

        #region Interface
        [Browsable(false)]
        public Control ActiveControl
        {
            get
            {
                return this.activeControl;
            }
            set
            {
                this.activeControl = value;
            }
        }

        public bool ActivateControl(Control ctrl)
        {
            if (!this.Controls.Contains(ctrl))
                return false;
            ctrl.Select();
            this.activeControl = ctrl;
            return true;
        }
        #endregion

        #region Content
        [DefaultValue(ContentAlignment.TopLeft)]
        [Category("Hyacinth Appearance")]
        public ContentAlignment TileImageAlign
        {
            get
            {
                return this.tileImageAlign;
            }
            set
            {
                this.tileImageAlign = value;
            }
        }
        #endregion

        #region Color Booleans
        [DefaultValue(false)]
        [Category("Hyacinth Appearance")]
        public bool CustomBackground
        {
            get
            {
                return this.useCustomBackground;
            }
            set
            {
                this.useCustomBackground = value;
            }
        }

        [DefaultValue(false)]
        [Category("Hyacinth Appearance")]
        public bool CustomForeColor
        {
            get
            {
                return this.useCustomForeColor;
            }
            set
            {
                this.useCustomForeColor = value;
            }
        }
        #endregion

        public HyacinthTile()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.TextAlign = ContentAlignment.BottomLeft;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //back color is used for the gap for the pressing animation
            Color color = HyacinthPalette.GetStyleColor(HyacinthColorStyle.Black); // default color based on style config
            if (this.useCustomBackground)
                color = this.BackColor;
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            //Pressed
            if (!this.isPressed)
            {
                e.Graphics.Clear(color);
            }
            else
            {
                e.Graphics.Clear(this.Parent.BackColor);
                using (SolidBrush solidBrush = new SolidBrush(color))
                {
                    Point[] points = new Point[4]
                    {
                    new Point(0, 0),
                    new Point(this.Width - 1, 2),
                    new Point(this.Width - 1, this.Height - 2),
                    new Point(0, this.Height)
                    };
                    e.Graphics.FillPolygon((Brush)solidBrush, points);
                }
            }
        }

        #region Mouse Overrides
        protected override void OnMouseEnter(EventArgs e)
        {
            this.isHovered = true;
            this.Invalidate();
            base.OnMouseEnter(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.isPressed = true;
                this.Invalidate();
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            this.isPressed = false;
            this.Invalidate();
            base.OnMouseUp(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.isHovered = false;
            this.Invalidate();
            base.OnMouseLeave(e);
        }
        #endregion

        #region Focus Properties
        protected override void OnGotFocus(EventArgs e)
        {
            this.isFocused = true;
            this.Invalidate();
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            this.isFocused = false;
            this.isHovered = false;
            this.isPressed = false;
            this.Invalidate();
            base.OnLostFocus(e);
        }
        #endregion
    }
}
