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


namespace uch.Diagram
{

    public partial class Diagram : UserControl
    {
        public List<Actor> Actors => actors;


        public List<Relationship> Relationships => relationships;


        public List<Usecase> Usecases => usecases;

        public Pen PenDefault { get; private set; } = new Pen(Color.Black);

        public Pen PenSelection { get; private set; } = new Pen(Color.Red);


        List<Actor> actors = new List<Actor>();
        List<Usecase> usecases = new List<Usecase>(); 
        List<Relationship> relationships = new List<Relationship>();

        public Diagram()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Creates a blank new actor in this diagram.
        /// </summary>
        public void CreateActor(int x = 0, int y = 0)
        {
            Actor actor = new Actor(this);

            if (x > 0 && y > 0)
                actor.Location = new Point(x, y);

            // Append a number to avoid duplicate naming.
            actor.Name += actors.Count + 1;

            // Include him in our lists.
            actors.Add(actor);
            Controls.Add(actor);

            // Make sure that nothing is selected.
            Deselect();

            // Select our newly created actor.
            actor.SelectAll();
        }



        public void DestroyActor(Actor actor)
        {
            if (Controls.Contains(actor))
            {
                Controls.Remove(actor);
                relationships.RemoveAll(r => r.Actor == actor);
                actors.RemoveAll(a => a == actor);
            }
        }

        /// <summary>
        /// Create a blank new usecase in this diagram.
        /// </summary>
        public void CreateUsecase(int x = 0, int y = 0)
        {
            Usecase usecase = new Usecase(this);

            if (x > 0 && y > 0)
                usecase.Location = new Point(x, y);

            // Append a number to avoid duplicate naming.
            usecase.Name += usecases.Count + 1;

            // Add it in our lists.
            usecases.Add(usecase);
            Controls.Add(usecase);

            // Make sure nothing is selected.
            Deselect();

            // Select our newly created usecase.
            usecase.Select();
        }

        public void DestroyUsecase(Usecase usecase)
        {
            if (Controls.Contains(usecase))
            {
                Controls.Remove(usecase);
                relationships.RemoveAll(r => r.Usecase == usecase);
                usecases.RemoveAll(a => a == usecase);
            }
        }


        /// <summary>
        /// Creates a relationship between two entities.
        /// </summary>
        /// <param name="actor"> Determines the actor to connect from. </param>
        /// <param name="usecase"> Determines the usecase to connect to. </param>
        public void CreateRelationship(Actor actor, Usecase usecase)
        {
            // If the relationship doesn't exist already.
            if (relationships.Count(x => x.Actor == actor && x.Usecase == usecase) < 1)
            {
                relationships.Add(new Relationship(actor, usecase));
            }
        }


        /// <summary>
        /// Destroys the relationship between two entities if it exists.
        /// </summary>
        /// <param name="actor"> The actor to disconnect. </param>
        /// <param name="usecase"> The usecase to disconnect him from. </param>
        public void DestroyRelationship(Actor actor, Usecase usecase)
        {
            relationships.RemoveAll(x => x.Actor == actor && x.Usecase == usecase);
        }


        /// <summary>
        /// Returns a collection of relationships that exist for the given actor.
        /// </summary>
        /// <param name="actor"> The actor to search for. </param>
        /// <returns> An IEnumerable with its relationships. </returns>
        public IEnumerable<Relationship> FindRelationships(Actor actor)
        {
            return relationships.Where(x => x.Actor == actor);
        }


        /// <summary>
        /// Returns a collection of relationships that exist for the given usecase.
        /// </summary>
        /// <param name="usecase"> The usecase to query by. </param>
        /// <returns> An IEnumerable with its relationships. </returns>
        public IEnumerable<Relationship> FindRelationships(Usecase usecase)
        {
            return relationships.Where(x => x.Usecase == usecase);
        }



        /// <summary>
        /// De-selects any entity in this diagram.
        /// </summary>
        public void Deselect()
        {
            actors.ForEach(a => a.Unselect());
            usecases.ForEach(u => u.Unselect());
        }


        /// <summary>
        /// Removes all entities from this diagram.
        /// </summary>
        public void Clear()
        {
            Controls.Clear();
            actors = new List<Actor>();
            usecases = new List<Usecase>();
            relationships = new List<Relationship>();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {

            // Draw lines to visualize relationships.
            foreach (Relationship r in relationships)
            {
                // Calculate the actors center position.
                Point actorCenter = r.Actor.Location;
                actorCenter.X += r.Actor.BackgroundImage.Width / 2;
                actorCenter.Y += r.Actor.BackgroundImage.Height / 2;

                Point usecaseCenter = r.Usecase.Location;
                usecaseCenter.X += r.Usecase.BackgroundImage.Width / 2;
                usecaseCenter.Y += r.Usecase.BackgroundImage.Height / 2;

                e.Graphics.DrawLine(PenDefault, actorCenter, usecaseCenter );
            }
        }


        private void OnDiagramClick(object sender, EventArgs e)
        {
            // Clicking anywhere in the diagram other than entities means deselecting them.
            Deselect();
        }

        private void createActorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var relativePosition = PointToClient(MousePosition);
            CreateActor(relativePosition.X, relativePosition.Y);
        }
    }
}
