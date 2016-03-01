using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uch.Diagram
{
    public class Line : Element
    {



        public Line(Point start, Point end) : base(start)
        {
            
        }



        public override bool Contains(Point point)
        {
            return base.Contains(point);
        }



        public override void Draw(Graphics graphics)
        {
            base.Draw(graphics);
        }

    }
}
