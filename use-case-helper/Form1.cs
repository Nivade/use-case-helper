using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uch.Drawables;


namespace use_case_helper
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, MouseEventArgs e)
        {

            var diagramMousePosition = diagram.PointToClient(Cursor.Position);

            if (rbCreate.Checked)
            {
                if (rbActor.Checked)
                {
                    diagram.Create(new Actor(diagramMousePosition));
                }
            }
            else if (rbSelect.Checked)
            {
                
            }
        }
    }
}
