using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UseCaseHelper.Forms;

namespace UseCaseHelper.Controls
{
    
    public partial class Diagram : UserControl
    {
        private List<Element> elements = new List<Element>();
        public UseCaseProperties UseCasePropertyForm { get; set; }
        public Element ActiveElement { get; set; }
        public bool ActiveElementPressed { get; set; }
        public Point PreviousLocation { get; private set; }
        public Form MainForm { get; private set; }
        private Timer timer = new Timer();

        public Diagram()
        {
            InitializeComponent();

            timer.Enabled = true;
            timer.Interval = 100;
            timer.Tick += TimerCallback;
        }

        private void TimerCallback(object sender, EventArgs e)
        {
            Invalidate();
        }

        public Diagram(Form parent) : this()
        {
            MainForm = parent;
        }


        /// <summary>
        /// Fires when the user clicks anywhere in the diagram.
        /// </summary>
        private void OnDiagramClicked(object sender, EventArgs e)
        {
            DeselectAll();
        }


        /// <summary>
        /// Deselects every element in the diagram.
        /// </summary>
        public void DeselectAll()
        {
            ActiveElement = null;
            ActiveElementPressed = false;

            elements.ForEach(x => x.Deactivate());
        }


        /// <summary>
        /// Activates an element.
        /// </summary>
        /// <param name="element"> Specifies the element to activate. </param>
        public void MakeActive(Element element)
        {
            ActiveElement?.Deactivate();

            ActiveElement = element;

            ActiveElement.Activate();
        }



        /// <summary>
        /// Initializes an existing element with default properties.
        /// </summary>
        /// <param name="element"> Specifies the element to initialize. </param>
        public void CreateElement(Element element)
        {
            DeselectAll();

            element.Location = PointToClient(new Point(MousePosition.X - element.Size.Width / 2, MousePosition.Y - element.Size.Height / 2));
            element.MouseDown += OnElementMouseDown;
            element.MouseUp += OnElementMouseUp;
            element.MouseMove += OnElementMouseMove;

            if (typeof(UseCaseControl) == element.GetType())
            {
                ((UseCaseControl) element).Activated += ShowPropertyForm;
                ((UseCaseControl) element).Deactivated += ClosePropertyForm;
            }

            
            MakeActive(element);

            elements.Add(element);
            Controls.Add(element);
        }

        private void OnCreateActorClick(object sender, EventArgs e)
        {
            CreateElement(new ActorControl());
        }

        private void OnCreateUseCaseClick(object sender, EventArgs e)
        {
            CreateElement(new UseCaseControl());
        }

        private void ShowPropertyForm(object sender, EventArgs e)
        {
            List<ActorControl> actors = new List<ActorControl>();
            foreach (var element in elements)
            {
                if (element.GetType() == typeof(ActorControl))
                    actors.Add((ActorControl)element);
            }

            UseCasePropertyForm = new UseCaseProperties((UseCaseControl)sender, actors);
            UseCasePropertyForm.Show();
            UseCasePropertyForm.Location = new Point(MainForm.Location.X + MainForm.Size.Width, MainForm.Location.Y);
        }
        private void ClosePropertyForm(object sender, EventArgs e)
        {
            UseCasePropertyForm.Close();
        }

        /// <summary>
        /// Prepares the element for dragging.
        /// </summary>
        protected void OnElementMouseDown(object sender, MouseEventArgs e)
        {
            ActiveElementPressed = true;
            PreviousLocation = e.Location;
            Cursor = Cursors.Hand;

            MakeActive((Element) sender);
        }


        /// <summary>
        /// Drags the active element.
        /// </summary>
        protected void OnElementMouseMove(object sender, MouseEventArgs e)
        {
            if (ActiveElement == null || ActiveElement != sender || !ActiveElementPressed)
                return;

            var location = ActiveElement.Location;

            location.Offset(e.Location.X - PreviousLocation.X, e.Location.Y - PreviousLocation.Y);

            ActiveElement.Location = location;
        }


        /// <summary>
        /// Drops the active element.
        /// </summary>
        protected void OnElementMouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
            ActiveElementPressed = false;
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);

            foreach (var element in elements)
            {
                if (element.GetType() == typeof(UseCaseControl))
                {
                    Point elementCenter = new Point(element.Location.X + element.Size.Width / 2,
                            element.Location.Y + element.Size.Height / 2);

                    foreach (ActorControl actor in ((UseCaseControl) element).Actors)
                    {
                        Point actorCenter = new Point(actor.Location.X + actor.Size.Width / 2,
                            actor.Location.Y + actor.Size.Height / 2);

                        e.Graphics.DrawLine(new Pen(Color.Black), elementCenter, actorCenter);
                    }
                }
            }


        }
    }
}
