//using Hyacinth.Controls.Drawing;
//using Hyacinth.Controls.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Hyacinth.Controls.Usables
//{
//    //sidenote: application programming interface
//    [EditorBrowsable(EditorBrowsableState.Advanced)]
//    public abstract class HyacinthButtonBase : Button, IDisposable, IHyacinthStyledComponent
//    {
//        private readonly MetroStyleManager _styleManager;

//        protected HyacinthButtonBase()
//        {
//            this._styleManager = new MetroStyleManager();
//            this._styleManager.MetroStyleChanged += new EventHandler(this.OnHyacinthStyleChanged);
//        }

//        #region Event
//        private void OnHyacinthStyleChanged(object sender, EventArgs e)
//        {
//            if (this.InvokeRequired)
//                this.Invoke((Delegate)new MethodInvoker(((Control)this).Invalidate));
//            else
//                this.Invalidate();
//        }
//        #endregion

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//                this._styleManager.Dispose();
//            base.Dispose(disposing);
//        }

//        [Category("Hyacinth Appearance")]
//        [AmbientValue(HyacinthColorStyle.Default)]
//        [DefaultValue(HyacinthColorStyle.Default)]
//        public HyacinthColorStyle Style
//        {
//            get
//            {
//                return this._styleManager.Style;
//            }
//            set
//            {
//                this._styleManager.Style = value;
//            }
//        }
//    }
//}
