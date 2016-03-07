using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uch.Diagram.Objects;
using Actor = uch.Diagram.Objects.Actor;


namespace uch.Diagram
{

    public partial class Diagram : UserControl
    {
        public List<Actor> Actors { get { return actors; } }


        List<ModelObject> elements = new List<ModelObject>();
        List<Actor> actors = new List<Actor>();
        List<Usecase> usecases = new List<Usecase>(); 

        public Diagram()
        {
            InitializeComponent();
        }



        public void CreateActor()
        {
            Actor actor = new Actor(this);

            actors.Add(actor);
            Controls.Add(actor);

            foreach (Actor a in actors)
                a.Unselect();

            actor.SelectAll();
        }



        public void CreateUsecase()
        {
            Usecase usecase = new Usecase(this);

            usecases.Add(usecase);
            Controls.Add(usecase);

            foreach (Usecase c in usecases)
                c.Unselect();

            usecase.Select();
        }


        /// <summary>
        /// Adds the given element to the diagram.
        /// </summary>
        /// <param name="modelObject"> The element to add. </param>
        public void Create(ModelObject modelObject)
        {
            if (modelObject == null)
            {
                Console.WriteLine("Diagram::Create: Element is null");
                return;
            }

            elements.Add(modelObject);

            Refresh();

            modelObject.PropertyChanged += (sender, args) => Refresh();
        }



        public void Select(Point point)
        {

           
            foreach (ModelObject e in elements)
            {
                if (e.IsSelected)
                    e.IsSelected = false;

                if (e.Contains(point))
                {
                    e.IsSelected = true;
                    Refresh();
                }
            }
        }

        private void OnClick(object sender, EventArgs e)
        {
            foreach (Actor a in actors)
                a.Unselect();

            foreach (Usecase c in usecases)
                c.Unselect();
        }
    }
}
