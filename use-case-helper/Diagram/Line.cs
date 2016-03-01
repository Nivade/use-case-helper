using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uch.Diagram
{
    public class Line : Element, IDrawable
    {



        public Line(Point start, Point end)
        {
            
        }



        public override bool Contains(Point point)
        {
            return base.Contains(point);
        }



        public void Draw(Graphics graphics)
        {
            
        }

    }
}
