using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uch.Properties;


namespace uch.Diagram.Objects
{
    public partial class Usecase : UserControl
    {

        public string Name
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        }

        public string Samenvatting { get; set; } = string.Empty;

        public string Aannamen { get; set; } = string.Empty;

        public string Beschrijving { get; set; } = string.Empty;

        public string Uitzonderingen { get; set; } = string.Empty;

        public string Resultaat { get; set; } = string.Empty;

        public List<Actor> Relationships { get; set; } = new List<Actor>(); 

        private Diagram parentDiagram;
        private bool selected = false;
        private UsecasePropertyForm propertyForm;

        public Usecase(Diagram parentDiagram)
        {
            InitializeComponent();
            this.parentDiagram = parentDiagram;

            propertyForm = new UsecasePropertyForm(this, parentDiagram);
            propertyForm.Show();
        }



        public new void Select()
        {
            selected = true;
            BackgroundImage = Resources.usecase_selected;
        }

        public void Unselect()
        {
            selected = false;
            BackgroundImage = Resources.usecase;
        }

        public void SelectAll()
        {
            Select();
        }

        private void OnTbNameTextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(tbName.Text, tbName.Font);
            tbName.Width = size.Width;
        }

        private Point MouseDownLocation;

        private void BeginDrag(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLocation = e.Location;
            }
        }

        private void Drag(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Left = e.X + Left - MouseDownLocation.X;
                Top = e.Y + Top - MouseDownLocation.Y;
            }
        }

        private void DoubleClick(object sender, EventArgs e)
        {
            propertyForm = new UsecasePropertyForm(this, parentDiagram);
            propertyForm.Show();
        }

        
    }
}
