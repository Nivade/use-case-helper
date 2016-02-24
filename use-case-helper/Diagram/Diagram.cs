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

    public partial class Diagram : UserControl
    {
        List<Element> elements = new List<Element>();

        public Diagram()
        {
            InitializeComponent();
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
