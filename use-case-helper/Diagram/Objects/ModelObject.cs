using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uch
{
    public class ModelObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public virtual bool IsSelected
        {
            get { return isSelected; }
            set { isSelected = value; }   
        }


        protected bool isSelected = false;

        public ModelObject()
        {

        }

        public virtual bool Contains(Point point)
        {
            return false;
        }



        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

    }
}
