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
    public partial class Actor : Element
    {

        public string Name { get; set; }


        public Actor(Diagram diagram) : base(diagram)
        {
            InitializeComponent();
        }

        public override void Activate()
        {
            base.Activate();

            tbName.Enabled = true;
            tbName.Focus();
        }

        public override void Deactivate()
        {
            tbName.Enabled = false;

            base.Deactivate();
        }
    }
}
