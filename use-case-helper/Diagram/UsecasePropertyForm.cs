using System;
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

            load();
        }



        private void load()
        {
            ClearAll();

            tbNaam.Text = usecase.Name;
            tbSamenvatting.Text = usecase.Samenvatting;
            tbAannamen.Text = usecase.Aannamen;
            tbBeschrijving.Text = usecase.Beschrijving;
            tbUitzonderingen.Text = usecase.Uitzonderingen;
            tbResultaat.Text = usecase.Resultaat;

            foreach (Actor a in usecase.Relationships)
            {
                tbActoren.Text += a.ToString() + ", ";
            }

            foreach (Actor a in diagram.Actors)
            {
                if (!usecase.Relationships.Contains(a))
                {
                    cbActors.Items.Add(a.ToString());
                    cbActors.Refresh();
                }
            }


            tbNaam.Focus();
        }



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

        private void Save(object sender, EventArgs e)
        {
            usecase.Name = tbNaam.Text;
            usecase.Samenvatting = tbSamenvatting.Text;
            usecase.Aannamen = tbAannamen.Text;
            usecase.Beschrijving = tbBeschrijving.Text;
            usecase.Uitzonderingen = tbUitzonderingen.Text;
            usecase.Resultaat = tbResultaat.Text;
        }

        private void ActorSelected(object sender, EventArgs e)
        {
            Actor actor = diagram.Actors.First(x => x.Name == cbActors.SelectedItem.ToString());
            diagram.CreateRelationship(actor, usecase);

        }
    }
}
