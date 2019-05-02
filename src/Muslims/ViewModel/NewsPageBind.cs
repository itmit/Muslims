using System;
using System.Collections.Generic;
using System.ComponentModel;
using Muslims.Models;
using System.Text;

namespace Muslims.ViewModel
{
    class NewsPageBind : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private NewsPageProperties property;

        public NewsPageBind()
        {
            property = new NewsPageProperties();
        }

        public string Title
        {
            get { return property.Title; }
            set
            {
                if (property.Title != value)
                {
                    property.Title = value;
                    OnPropertyChanged("Title");
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
