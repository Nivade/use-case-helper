using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uch.Drawables;


namespace uch.Diagram
{
    public enum Mode
    {
        Actor,
        Line,
        UseCase
    }

    public partial class Diagram : UserControl
    {
        public Mode Mode { get; set; }



        List<Element> elements = new List<Element>();

        public Diagram()
        {
            InitializeComponent();

            Mode = Mode.Actor;
        }



        public void Create(Element element)
        {
            if (element == null)
            {
                Console.WriteLine("Diagram::Create: Element is null");
                return;
            }

            elements.Add(element);

            Refresh();
        }

        private void OnClick(object sender, EventArgs e)
        {
            /*var relativeMouse = this.PointToClient(Cursor.Position);

            switch (Mode)
            {
                case Mode.Actor:
                    elements.Add(new Actor(relativeMouse));
                    break;
            }


            Refresh();*/
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            foreach (Element element in elements)
            {
                element.Draw(e.Graphics);
            }
        }
    }
}
