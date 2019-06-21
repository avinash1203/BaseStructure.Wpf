using Structure.Base.Interfaces;
using System.ComponentModel;

namespace Structure.Base.AbstractClass
{
    abstract class BaseViewModel : IBaseViewModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyRaised(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
