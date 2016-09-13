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
    public partial class ActorControl : Element
    {
        public new string Name
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        }

        public ActorControl()
        {
            InitializeComponent();
        }

        public override void Activate()
        {
            base.Activate();

            // Select the textbox.
            //tbName.Enabled = true;
            //tbName.Focus();
        }

        public override void Deactivate()
        {
            //tbName.Enabled = false;
            base.Deactivate();
        }
    }
}
