using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UseCaseHelper.Controls;

namespace UseCaseHelper
{
    public partial class MainForm : Form
    {



        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateActorClick(object sender, EventArgs e)
        {
            diagram.CreateElement(new ActorControl());
        }

        private void CreateUseCaseClick(object sender, EventArgs e)
        {
            diagram.CreateElement(new UseCaseControl());
        }
    }
}
