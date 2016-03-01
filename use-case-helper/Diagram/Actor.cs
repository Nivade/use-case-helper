using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uch.Diagram;


namespace uch.Drawables
{
    public class Actor : Element, IDrawable
    {
        private readonly Image graphic = Image.FromFile("Assets/stickman.png");
        private Point position;

        public Actor(Point position)
        {
            this.position = position;
        }


        /// <summary>
        /// Returns true if the given point is inside this actor.
        /// </summary>
        /// <param name="point"> The point to check agains. </param>
        /// <returns></returns>
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


        public void Draw(Graphics graphics)
        {
            graphics.DrawImage(graphic, position);
        }

    }
}
