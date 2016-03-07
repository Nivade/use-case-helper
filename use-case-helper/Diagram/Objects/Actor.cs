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

        private bool selected;
        private bool dragging;
        private readonly Diagram parent;

        /// <summary>
        /// Used for dragging, represents the initial mouse down position.
        /// </summary>
        private Point mouseDownLocation;

        public Actor(Diagram parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void OnDoubleClick(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            // Confirm changes if enter is pressed.
            if (e.KeyCode == Keys.Enter)
            {
                Name = tbName.Text;
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



        /// <summary>
        /// Sets the initial mouse down position.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BeginDrag(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                parent.UnselectAll();

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

                dragging = true;
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

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                dragging = false;
            }
            else
            {
                Select();
            }
        }
    }
}
