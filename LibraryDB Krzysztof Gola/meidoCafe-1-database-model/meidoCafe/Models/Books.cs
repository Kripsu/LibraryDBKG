using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book : INotifyPropertyChanged
    {

        string name;
        public int BookId { get; set; }
        public string Description { get; set; }
        public string BookName
        {
            get => name;
            set
            {
                if (value != name)
                {
                    name = value;
                    NotifypropertyChanged("BookName");
                }
            }

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifypropertyChanged(string v)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }

        }
    }



}
