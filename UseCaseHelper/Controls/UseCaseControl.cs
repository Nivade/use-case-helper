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

namespace UseCaseHelper.Controls
{
    public partial class UseCaseControl : Element
    {

        public UseCase UseCase => new UseCase();

        public UseCaseControl(Diagram diagram) : base(diagram)
        {
            InitializeComponent();
        }
    }
}
