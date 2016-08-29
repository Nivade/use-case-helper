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

        private List<Element> elements;


        public Diagram()
        {
            InitializeComponent();
        }

        public Actor CreateActor()
        {
            Actor actor = new Actor();
            Controls.Add(actor);

            return actor;

        }

        public UseCase CreateUseCase()
        {
            return null;
        }

        private void AddActorDiagramContextMenuClick(object sender, EventArgs e)
        {

        }
    }
}
