using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uch.Diagram.Objects;


namespace uch.Diagram
{
    public class Relationship
    {

        public Actor Actor { get; private set; }


        public Usecase Usecase { get; private set; }



        public Relationship(Actor actor, Usecase usecase)
        {
            this.Actor = actor;
            this.Usecase = usecase;
        }

    }
}
