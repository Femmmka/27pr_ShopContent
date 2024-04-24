using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;

namespace ShopContent.Modell
{
    public class Items : INotifyPropertyChanged
    {
        private int id;
        public int Id
        {
            get { return id; }
            set{
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
                OnProperyChanged("Name");
            }
        }
        private double price;
        public double Price
        {
            get { return Price; }
            set
            {
                price = value;
                OnProperyChanged("Price");
            }
        }
        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
                OnProperyChanged("Description");
            }
        }
        private Categorys category;
        public Categorys Category
        {
            get { return category; }
            set
            {
                category = value;
                OnProperyChanged("Category");
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
