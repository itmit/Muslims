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
	public partial class Names : ContentPage
	{
		public Names ()
		{
			InitializeComponent ();
            Names_Init();

        }
        public void Names_Init()
        {
            List<Names_Class> Library = new List<Names_Class>
            {
                new Names_Class { Names_ID = "1", Names_Title = "Мужские мусульманские имена" },
                new Names_Class { Names_ID = "2", Names_Title = "Женские мусульманские имена" },
            };

            Names_Menu.ItemsSource = Library;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    {
                        Names_Menu.Margin = new Thickness(0, 21, 0, 0);
                        break;
                    }
                case Device.Android:
                    {
                        Names_Menu.Margin = new Thickness(0, 21, 0, 0);
                        break;
                    };
            }
        }
        public void Names_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var Names = e.SelectedItem as Names_Class;
            if (Names != null)
            {
                if (Names.Names_ID.Equals("1"))
                {
                    Navigation.PushAsync(new Mans_Names());
                }
                else if (Names.Names_ID.Equals("2"))
                {
                    Navigation.PushAsync(new Womans_Names());
                }
            }
        }
    }
    public class Names_Class
    {
        public string Names_ID
        {
            get;
            set;
        }
        public string Names_Title
        {
            get;
            set;
        }
    }
}