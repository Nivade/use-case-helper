using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uch.Diagram
{
    public partial class PropertyWindow : Form
    {

        public Element ActiveElement
        {
            get { return activeElement; }
            set
            {
                if (value == null)
                    return;

                activeElement = value;
                Work((UseCase) value);
            }
        }


        private Element activeElement;
        private readonly Form parent;


        public PropertyWindow(Form parent, UseCase usecase)
        {
            InitializeComponent();

            ActiveElement = usecase;
            this.parent = parent;
        }



        public void Work(UseCase usecase)
        {
            tbNaam.Text = usecase.Naam;
            tbSamenvatting.Text = usecase.Samenvatting;
        }

        private void OnTextboxNameChanged(object sender, EventArgs e)
        {
            if (ActiveElement != null)
            {
                ((UseCase) ActiveElement).Naam = tbNaam.Text;
                parent?.Refresh();
            }
        }
    }
}
