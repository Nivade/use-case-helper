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
        Image graphic = Image.FromFile("Assets/stickman.png");

        public Actor(Point position) : base(position)
        {

        }



        public override void Draw(Graphics graphics)
        {
            graphics.DrawImage(graphic, position);
        }

    }
}
