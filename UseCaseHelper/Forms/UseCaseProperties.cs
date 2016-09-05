using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UseCaseHelper.Domain;

namespace UseCaseHelper.Forms
{
    public partial class UseCaseProperties : Form
    {

        private UseCase useCase;

        public UseCaseProperties(UseCase useCase)
        {
            this.useCase = useCase;
        }
    }
}
