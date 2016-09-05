using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UseCaseHelper.Domain;

namespace UseCaseHelper.Controls
{
    public partial class Diagram : UserControl
    {

        private List<UserControl> elements = new List<UserControl>();


        public Diagram()
        {
            InitializeComponent();
        }

        public Actor CreateActor(int x = 0, int y = 0)
        {
            Actor actor = new Actor();
            actor.Location = new Point(x, y);
            Controls.Add(actor);
            elements.Add(actor);
            actor.Focus();
            return actor;
        }

        public UseCase CreateUseCase()
        {
            return null;
        }

        private void AddActorDiagramContextMenuClick(object sender, EventArgs e)
        {
            var relativeMousePosition = PointToClient(new Point(MousePosition.X, MousePosition.Y));
            CreateActor(relativeMousePosition.X, relativeMousePosition.Y);
        }
    }
}
