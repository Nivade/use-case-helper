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
        

        public Element()
        {

        }

        public virtual bool Contains(Point point)
        {
            return false;
        }
    }
}
