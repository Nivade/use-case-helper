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

        private readonly Diagram parent;
        private bool selected = false;
        private UsecasePropertyForm propertyForm;

        /// <summary>
        /// Used for dragging, represents the initial mouse down position.
        /// </summary>
        private Point mouseDownLocation;

        public Usecase(Diagram parent)
        {
            InitializeComponent();
            this.parent = parent;

            ShowPropertyForm();
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

        private void OnTbNameTextChanged(object sender, EventArgs e)
        {
            Size size = TextRenderer.MeasureText(tbName.Text, tbName.Font);
            tbName.Width = size.Width;
        }


        /// <summary>
        /// Sets the initial mouse down position.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BeginDrag(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                parent.Deselect();

                // Select this usecase if it wasn't already.
                Select();

                mouseDownLocation = e.Location;
            }
        }


        /// <summary>
        /// Mouse this actor with the mouse as long as the left mouse button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Drag(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Left = e.X + Left - mouseDownLocation.X;
                Top = e.Y + Top - mouseDownLocation.Y;

                parent.Refresh();
            }
        }

        private void DoubleClick(object sender, EventArgs e)
        {
            ShowPropertyForm();
        }

        private void ShowPropertyForm()
        {
            if (propertyForm == null || propertyForm.IsDisposed)
                propertyForm = new UsecasePropertyForm(this, parent);

            propertyForm.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Select();
            ShowPropertyForm();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parent.DestroyUsecase(this);
        }
    }
}
