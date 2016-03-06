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

        private UsecasePropertyForm usecasePropertyForm;


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
    }
}
