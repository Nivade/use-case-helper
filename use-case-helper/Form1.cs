using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uch.Diagram;
using uch.Drawables;


namespace use_case_helper
{
    public partial class fMain : Form
    {

        private PropertyWindow propertyWindow;


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
                else if (rbUseCase.Checked)
                {

                    UseCase uc = new UseCase(diagramMousePosition, this.Font);
                    diagram.Create(uc);

                    PropertyWindow pw = new PropertyWindow(this, uc);
                    pw.Show(this);
                    pw.Location = new Point(Location.X + Width, Location.Y);

                }
            }
            else if (rbSelect.Checked)
            {
                diagram.Select(diagramMousePosition);

                if (propertyWindow == null)
                {
                    //propertyWindow = new PropertyWindow();
                }
            }
        }
    }
}
