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
    public partial class UseCase : Element
    {
        public UseCase()
        {
            InitializeComponent();
        }

        public UseCase(Diagram diagram) : this()
        {
            this.diagram = diagram;
        }
    }
}
