using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Muslims
{
    class Gallery_Bind : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Gallery_Image path;

        public Gallery_Bind()
        {
            path = new Gallery_Image();
        }

        public string Image
        {
            get { return path.Image_Path; }
            set
            {
                if (path.Image_Path != value)
                {
                    path.Image_Path = value;
                    OnPropertyChanged("ImagePath");
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
