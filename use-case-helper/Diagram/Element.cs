using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uch
{
    public class Element
    {

        protected Point position;

        public Element(Point position)
        {
            this.position = position;
        }

        public virtual void Draw(Graphics graphics)
        {
            
        }
    }
}
