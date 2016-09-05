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
    public partial class Element : UserControl
    {

        /// <summary>
        /// Specifies the diagram containing this control.
        /// </summary>
        protected Diagram diagram;


        /// <summary>
        /// Specifies the original background image of the element.
        /// </summary>
        [Category("Custom")]
        [Description("Specifies the original actor image.")]
        [Browsable(true)]
        public Bitmap OriginalBackgroundImage { get; set; }


        /// <summary>
        /// Specifies the background image that's shown when the element is selected.
        /// </summary>
        [Category("Custom")]
        [Description("Specifies the selected actor image.")]
        [Browsable(true)]
        public Bitmap SelectedBackgroundImage { get; set; }


        public Element()
        {
            InitializeComponent();
        }

        public Element(Diagram diagram) : this()
        {
            this.diagram = diagram;
        }


        /// <summary>
        /// Activates the element.
        /// </summary>
        public virtual void Activate()
        {
            Focus();
            BackgroundImage = SelectedBackgroundImage;
        }


        /// <summary>
        /// Deactivates the element.
        /// </summary>
        public virtual void Deactivate()
        {
            InvokeLostFocus(this, null);
            BackgroundImage = OriginalBackgroundImage;
        }


    }
}
