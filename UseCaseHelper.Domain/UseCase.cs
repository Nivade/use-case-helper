using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper.Domain
{
    public class UseCase : Element
    {
        public IEnumerable<Actor> Actors { get; set; }
    }
}
