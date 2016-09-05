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
        /// Specifies the orignal element image.
        /// </summary>
        [Category("Custom")]
        [Description("Specifies the original actor image.")]
        [Browsable(true)]
        public Bitmap Original { get; set; }


        /// <summary>
        /// Specifies the selected element image.
        /// </summary>
        [Category("Custom")]
        [Description("Specifies the selected actor image.")]
        [Browsable(true)]
        public Bitmap Selected { get; set; }


        public Element()
        {
            InitializeComponent();
        }

        public Element(Diagram diagram) : this()
        {
            this.diagram = diagram;
        }


        /// <summary>
        /// Selects the element.
        /// </summary>
        public new virtual void Select()
        {
            Focus();
            BackgroundImage = Selected;
        }


        /// <summary>
        /// Deselects the element.
        /// </summary>
        public virtual void Deselect()
        {
            InvokeLostFocus(this, null);
            BackgroundImage = Original;
        }


    }
}
