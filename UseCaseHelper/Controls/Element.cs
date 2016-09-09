using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseHelper.Controls
{

    public delegate void ElementActivatedHandler(object sender, EventArgs e);
    public delegate void ElementDeactivatedHandler(object sender, EventArgs e);

    public partial class Element : UserControl
    {
        public event ElementActivatedHandler Activated;
        public event ElementDeactivatedHandler Deactivated;


        /// <summary>
        /// Specifies element's background image.
        /// </summary>
        [Category("Custom")]
        [Description("Specifies the original actor image.")]
        [Browsable(true)]
        public Bitmap DefaultBackgroundImage { get; set; }


        /// <summary>
        /// Specifies the element's background image when it is active.
        /// </summary>
        [Category("Custom")]
        [Description("Specifies the selected actor image.")]
        [Browsable(true)]
        public Bitmap ActiveBackgroundImage { get; set; }


        public Element()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Activates the element.
        /// </summary>
        public virtual void Activate()
        {
            BackgroundImage = ActiveBackgroundImage;
            OnActivated(null);
        }


        /// <summary>
        /// Deactivates the element.
        /// </summary>
        public virtual void Deactivate()
        {
            BackgroundImage = DefaultBackgroundImage;
            OnDeactivated(null);
        }

        protected virtual void OnActivated(EventArgs e)
        {
            if (Activated != null)
                Activated(this, e);
        }

        protected virtual void OnDeactivated(EventArgs e)
        {
            if (Deactivated != null)
                Deactivated(this, e);
        }
    }
}
