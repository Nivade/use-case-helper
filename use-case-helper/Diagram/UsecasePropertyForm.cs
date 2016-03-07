using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using uch.Diagram.Objects;


namespace uch.Diagram
{
    public partial class UsecasePropertyForm : Form
    {
        private Usecase usecase;
        private Diagram diagram;

        public UsecasePropertyForm(Usecase usecase, Diagram diagram)
        {
            InitializeComponent();

            this.usecase = usecase;
            this.diagram = diagram;

            LoadUsecaseProperties();
        }


        /// <summary>
        /// Loads all usecase values into the form.
        /// </summary>
        private void LoadUsecaseProperties()
        {
            // Clear every field beforehand.
            ClearAll();

            // Write our usecase properties into their corresponing textboxes.
            tbNaam.Text = usecase.Name;
            tbSamenvatting.Text = usecase.Samenvatting;
            tbAannamen.Text = usecase.Aannamen;
            tbBeschrijving.Text = usecase.Beschrijving;
            tbUitzonderingen.Text = usecase.Uitzonderingen;
            tbResultaat.Text = usecase.Resultaat;

            FillRelationshipsTextBox();

            // Now fill the combobox with every actor in the diagram.
            // Clicking an actor either creates or destroys a relationship.
            foreach (Actor a in diagram.Actors)
                cbActors.Items.Add(a.ToString());

            tbNaam.Focus();
        }


        /// <summary>
        /// Completely clear all controlls.
        /// </summary>
        private void ClearAll()
        {
            tbNaam.Clear();
            tbSamenvatting.Clear();
            tbAannamen.Clear();
            tbBeschrijving.Clear();
            tbUitzonderingen.Clear();
            tbResultaat.Clear();
            tbActoren.Clear();
            cbActors.Items.Clear();
        }

        private void OnTextboxNameChanged(object sender, EventArgs e)
        {

            
        }



        private void FillRelationshipsTextBox()
        {
            tbActoren.Text = string.Empty;
            // Check for any relationships and write them in a textbox.
            foreach (Relationship r in diagram.FindRelationships(usecase))
            {
                tbActoren.Text += r.Actor.Name + "; ";
            }
        }

        /// <summary>
        /// Overwrite usecase property values with those in this form.
        /// </summary>
        public void Save()
        {
            usecase.Name = tbNaam.Text;
            usecase.Samenvatting = tbSamenvatting.Text;
            usecase.Aannamen = tbAannamen.Text;
            usecase.Beschrijving = tbBeschrijving.Text;
            usecase.Uitzonderingen = tbUitzonderingen.Text;
            usecase.Resultaat = tbResultaat.Text;
        }
        

        /// <summary>
        /// Save this usecase, then close the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnbtnSaveClick(object sender, EventArgs e)
        {
            Save();
            diagram.Refresh();
            Close();
        }

        private void OncbActorsSelectionChanged(object sender, EventArgs e)
        {
            // Get the Actor by it's name from our main diagram.
            Actor actor = diagram.Actors.First(x => x.Name == cbActors.SelectedItem.ToString());

            List<Relationship> existing = diagram.Relationships.Where(x => x.Actor == actor && x.Usecase == usecase).ToList();

            if (existing.Count > 0)
                diagram.DestroyRelationship(actor, usecase);
            else
                diagram.CreateRelationship(actor, usecase);

            FillRelationshipsTextBox();
            diagram.Refresh();
        }
    }
}
