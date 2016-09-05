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
        protected Diagram diagram;

        public Element()
        {
            InitializeComponent();
        }

        public Element(Diagram diagram) : this()
        {
            this.diagram = diagram;
        }
    }
}
