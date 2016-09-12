using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UseCaseHelper.Domain;
using UseCaseHelper.Forms;

namespace UseCaseHelper.Controls
{

    

    public partial class UseCaseControl : Element
    {
        public new string Name
        {
            get { return tbName.Text; }
            set { tbName.Text = value; }
        }
        public string Summary { get; set; }
        public ICollection<ActorControl> Actors { get; set; }
        public string Assumptions { get; set; }
        public string Description { get; set; }
        public string Exceptions { get; set; }
        public string Result { get; set; }

        public UseCaseControl()
        {
            InitializeComponent();
            Actors = new List<ActorControl>();
        }
    }
}
