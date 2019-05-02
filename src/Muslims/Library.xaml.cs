using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Library : ContentPage
	{
		public Library ()
		{
			InitializeComponent ();
            Library_Init();

        }
        public void Library_Init()
        {
            List<Library_Class> Library = new List<Library_Class>
            {
                new Library_Class { Library_ID = "1", Library_Title = "Словарь мусульманских терминов" },
                new Library_Class { Library_ID = "2", Library_Title = "Мусульманские имена" },
                new Library_Class { Library_ID = "3", Library_Title = "Общее" },
                new Library_Class { Library_ID = "4", Library_Title = "Для женщин" },
                new Library_Class { Library_ID = "5", Library_Title = "Ислам и дети" }
            };

            Library_Menu.ItemsSource = Library;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    {
                        Library_Menu.Margin = new Thickness(0, 21, 0, 0);
                        break;
                    }
                case Device.Android:
                    {
                        Library_Menu.Margin = new Thickness(0, 21, 0, 0);
                        break;
                    };
            }
        }
        public void Library_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var Library = e.SelectedItem as Library_Class;
            if (Library != null)
            {
                if (Library.Library_ID.Equals("1"))
                {
                    Navigation.PushAsync(new Vocabulary());
                }
                else if (Library.Library_ID.Equals("2"))
                {
                    Navigation.PushAsync(new Names());
                }
                else if (Library.Library_ID.Equals("5"))
                {
                    Navigation.PushAsync(new Kids());
                }
            }
        }
    }
    public class Library_Class
    {
        public string Library_ID
        {
            get;
            set;
        }
        public string Library_Title
        {
            get;
            set;
        }
    }
}