using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uch.Drawables;


namespace uch.Diagram
{
    public class UseCase : Element, IDrawable
    {

        public string Naam { get; set; } = "Sample";


        public string Samenvatting { get; set; } = "Samenvatting";
        private Rectangle bounds = new Rectangle(0, 0, 250, 75);
        private Font font;
         
        public UseCase(Point position, Font font)
        {
            bounds.X = position.X;
            bounds.Y = position.Y;
            this.font = font;

            Naam = "Sample";
        }



        public void Draw(Graphics graphics)
        {
            float width = Naam.Length * 20.0f;
            float centerX = bounds.X - (width / 2);
            float centerY = bounds.Y - (75.0f / 2);

            graphics.DrawEllipse(new Pen(Color.Black, 2.0f),
                centerX,
                centerY,
                width,
                bounds.Height); 

            graphics.DrawString(Naam, font, Brushes.Black,  bounds.X - (Naam.Length * 5), bounds.Y - 3.0f);
        }


    }
}
