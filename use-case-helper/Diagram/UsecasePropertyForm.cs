using System;
using System.Windows.Forms;
using uch.Diagram.Objects;


namespace uch.Diagram
{
    public partial class UsecasePropertyForm : Form
    {

        public Usecase ActiveUsecase
        {
            get { return activeUsecase; }
            set
            {
                if (value == null)
                    return;

                activeUsecase = value;

                load();
            }
        }


        private Usecase activeUsecase;
        private Form parent;

        public UsecasePropertyForm(Form parent, Usecase usecase)
        {
            InitializeComponent();
            this.parent = parent;
            ActiveUsecase = usecase;
        }



        private void load()
        {
            tbNaam.Text = ActiveUsecase.Name;
            tbSamenvatting.Text = ActiveUsecase.Samenvatting;
        }

        private void OnTextboxNameChanged(object sender, EventArgs e)
        {

            if (ActiveUsecase != null && parent != null)
            {
                ActiveUsecase.Name = tbNaam.Text;
            }
        }
    }
}
