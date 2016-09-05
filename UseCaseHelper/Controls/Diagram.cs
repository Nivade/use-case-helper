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

        private List<Element> elements = new List<Element>();


        public Diagram()
        {
            InitializeComponent();

            Element a = new Actor(this);

            elements.Add(a);
            Controls.Add(a);


        }

        private void OnClick(object sender, EventArgs e)
        {
            elements.ForEach(x => x.Deactivate());
            Focus();
        }
    }
}
