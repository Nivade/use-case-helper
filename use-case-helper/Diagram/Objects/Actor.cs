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
    public partial class Actor : UserControl
    {

        public new string Name
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        } 

        private bool selected = false;
        private Diagram parentDiagram;

        public Actor(Diagram parentDiagram)
        {
            InitializeComponent();
            this.parentDiagram = parentDiagram;
        }

        private void OnDoubleClick(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Name = tbName.Text;
                Unselect();
            }
        }

        public void Unselect()
        {
            selected = false;
            tbName.Enabled = false;
            BackgroundImage = Resources.stickman;
        }



        public new void Select()
        {
            selected = true;
            tbName.Enabled = true;
            BackgroundImage = Resources.stickman_selected;
        }

        public void SelectAll()
        {
            selected = true;
            BackgroundImage = Resources.stickman_selected;
            tbName.Enabled = true;
            tbName.Focus();
            tbName.SelectAll();
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

                parentDiagram.Refresh();
            }
        }



        /// <summary>
        /// Returns a <see cref="T:System.String"/> containing the name of the <see cref="T:System.ComponentModel.Component"/>, if any. This method should not be overridden.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> containing the name of the <see cref="T:System.ComponentModel.Component"/>, if any, or null if the <see cref="T:System.ComponentModel.Component"/> is unnamed.
        /// </returns>
        public override string ToString()
        {
            return Name;
        }

    }
}
