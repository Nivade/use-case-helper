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



        public void CreateActor()
        {
            Actor actor = new Actor(this);

            actors.Add(actor);
            Controls.Add(actor);

            // Unselect everything.
            UnselectAll();

            // Focus on the new actor.
            actor.SelectAll();
        }



        public void CreateUsecase()
        {
            Usecase usecase = new Usecase(this);

            usecases.Add(usecase);
            Controls.Add(usecase);

            UnselectAll();

            usecase.Select();
        }



        public void CreateRelationship(Actor actor, Usecase usecase)
        {
            // If the relationship doesn't exist already.
            if (relationships.Count(x => x.Actor == actor && x.Usecase == usecase) < 1)
            {
                relationships.Add(new Relationship(actor, usecase));
            }
        }



        public void DestroyRelationship(Actor actor, Usecase usecase)
        {
            relationships.RemoveAll(x => x.Actor == actor && x.Usecase == usecase);
        }



        public IEnumerable<Relationship> FindRelationships(Actor actor)
        {
            return relationships.Where(x => x.Actor == actor);
        }

        public IEnumerable<Relationship> FindRelationships(Usecase usecase)
        {
            return relationships.Where(x => x.Usecase == usecase);
        }

        private void OnClick(object sender, EventArgs e)
        {
            // Clicking anywhere in the diagram other than entities means deselecting them.
            UnselectAll();
        }



        public void UnselectAll()
        {
            foreach (Actor a in actors)
                a.Unselect();

            foreach (Usecase c in usecases)
                c.Unselect();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {

            // Draw a line from the 
            foreach (Relationship r in relationships)
            {
                // Calculate the actors center position.
                Point actorCenter = r.Actor.Location;
                actorCenter.X += r.Actor.BackgroundImage.Width / 2;
                actorCenter.Y += r.Actor.BackgroundImage.Height / 2;

                Point usecaseCenter = r.Usecase.Location;
                usecaseCenter.X += r.Usecase.BackgroundImage.Width / 2;
                usecaseCenter.Y += r.Usecase.BackgroundImage.Height / 2;

                e.Graphics.DrawLine(new Pen(Color.Black), actorCenter, usecaseCenter );
            }
        }
    }
}
