using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper.Domain
{
    public class UseCase : Element
    {
        public string Name { get; set; }
        public string Summary { get; set; }
        public IEnumerable<Actor> Actors { get; set; }

        public IEnumerable<string> Assumptions { get; set; }

        public string Description { get; set; }
        public string Exceptions { get; set; }
        public string Result { get; set; }
    }
}
