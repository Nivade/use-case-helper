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
        private UseCaseControl target;
        private IEnumerable<ActorControl> actors;

        public UseCaseProperties(UseCaseControl target, IEnumerable<ActorControl> actors )
        {
            InitializeComponent();

            this.target = target;
            this.actors = actors;

            PopulateFields(target);
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

            PopulateActorTextbox(useCase);
            
        }

        public void PopulateActorTextbox(UseCaseControl useCase)
        {
            tbActors.Text = string.Empty;
            foreach (ActorControl a in useCase.Actors)
            {
                tbActors.Text += a.Name + ", ";
            }
        }

        public void SaveFields()
        {
            target.Name = tbName.Text;
            target.Assumptions = tbAssumptions.Text;
            target.Description = tbDescription.Text;
            target.Result = tbResult.Text;
            target.Summary = tbSummary.Text;
            target.Exceptions = tbExceptions.Text;
        }

        private void populateActorComboBox()
        {
            if (actors == null)
                return;

            if (!actors.Any())
                return;

            foreach (var c in actors)
            {
                cbActors.Items.Add(c.Name);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFields();
            Close();
        }

        private void OnActorSelected(object sender, EventArgs e)
        {
            string name = cbActors.SelectedItem.ToString();

            ActorControl selectedActor = actors.Where(x => x.Name == name).First();

            if (target.Actors.Contains(selectedActor))
            {
                target.Actors.Remove(selectedActor);
            }
            else
            {
                target.Actors.Add(selectedActor);
            }

            PopulateActorTextbox(target);
        }
    }
}
