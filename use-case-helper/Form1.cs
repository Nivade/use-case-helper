using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using uch.Diagram;
using Actor = uch.Diagram.Objects.Actor;


namespace use_case_helper
{
    public partial class fMain : MaterialForm
    {


        public fMain()
        {
            InitializeComponent();
        }

        private void OnClick(object sender, MouseEventArgs e)
        {
            
        }

        private void OnInsertActorClicked(object sender, EventArgs e)
        {
            diagram.CreateActor();
            
        }

        private void OnInsertUsecaseClicked(object sender, EventArgs e)
        {
            diagram.CreateUsecase();
        }

        private void OnNewDiagramClick(object sender, EventArgs e)
        {
            diagram.Clear();
        }
    }
}
