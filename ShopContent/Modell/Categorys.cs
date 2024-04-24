using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ShopContent.Modell
{
    public class Categorys : INotifyPropertyChanged
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnProperyChanged("Id");
            }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnProperyChanged("name");
            }
        }
        public event PropertyChangedEventHandler ProperyChanged;
        public void OnProperyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangingEventArgs(prop));
        }
    }
}
