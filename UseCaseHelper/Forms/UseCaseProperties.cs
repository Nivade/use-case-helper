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
using UseCaseHelper.Controls;
using UseCaseHelper.Domain;

namespace UseCaseHelper.Forms
{
    public partial class UseCaseProperties : Form
    {
        private UseCaseControl activeUseCaseControl;
        private IEnumerable<ActorControl> actorControls;

        public UseCaseProperties(UseCaseControl activeUseCaseControl, IEnumerable<ActorControl> actorControls )
        {
            InitializeComponent();

            this.activeUseCaseControl = activeUseCaseControl;
            this.actorControls = actorControls;

            PopulateFields(activeUseCaseControl);
            populateActorComboBox();
        }

        public void PopulateFields(UseCaseControl useCase)
        {
            tbName.Text = useCase.Name;
            tbAssumptions.Text = useCase.Assumptions;
            tbDescription.Text = useCase.Description;
            tbResult.Text = useCase.Result;
            tbSummary.Text = useCase.Summary;
            tbExceptions.Text = useCase.Exceptions;
            
        }

        public void SaveFields()
        {
            activeUseCaseControl.Name = tbName.Text;
            activeUseCaseControl.Assumptions = tbAssumptions.Text;
            activeUseCaseControl.Description = tbDescription.Text;
            activeUseCaseControl.Result = tbResult.Text;
            activeUseCaseControl.Summary = tbSummary.Text;
            activeUseCaseControl.Exceptions = tbExceptions.Text;
        }

        private void populateActorComboBox()
        {
            if (actorControls == null)
                return;

            if (!actorControls.Any())
                return;

            foreach (var c in actorControls)
            {
                cbActors.Items.Add(c.Name);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFields();
            Close();
        }
    }
}
