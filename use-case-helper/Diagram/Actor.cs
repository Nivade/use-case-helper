using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uch.Drawables
{
    public class Actor : Element
    {
        private readonly Image graphic = Image.FromFile("Assets/stickman.png");

        public Actor(Point position) : base(position)
        {

        }



        public override bool Contains(Point point)
        {
            Rectangle boundingBox = new Rectangle(position, graphic.Size);

            if (point.X >= boundingBox.X && point.X <= (boundingBox.X + boundingBox.Width))
            {
                if (point.Y >= boundingBox.Y && point.Y <= (boundingBox.Y + boundingBox.Height))
                {
                    return true;
                }
            }

            return false;
        }


        public override void Draw(Graphics graphics)
        {
            graphics.DrawImage(graphic, position);
        }

    }
}
