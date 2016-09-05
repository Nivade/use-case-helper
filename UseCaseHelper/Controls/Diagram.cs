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

        public UseCase CreateUseCase()
        {
            return null;
        }
    }
}
