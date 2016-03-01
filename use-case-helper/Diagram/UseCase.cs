﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uch.Drawables;


namespace uch.Diagram
{
    public class UseCase : Element
    {
        List<Actor> actors = new List<Actor>();
         
        public UseCase(Point position) : base(position)
        {
            
        }


    }
}
