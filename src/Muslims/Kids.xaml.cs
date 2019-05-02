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
	public partial class Kids : ContentPage
	{
		public Kids()
		{
			InitializeComponent ();
            Kids_Init();

        }
        public void Kids_Init()
        {
            List<Kids_Class> Library = new List<Kids_Class>
            {
                new Kids_Class { Kids_ID = "1", Kids_Title = "Положение и права ребенка в исламе" },
                new Kids_Class { Kids_ID = "2", Kids_Title = "Воспитание подрастающего поколения в исламе" },
            };

            Kids_Menu.ItemsSource = Library;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    {
                        Kids_Menu.Margin = new Thickness(0, 21, 0, 0);
                        break;
                    }
                case Device.Android:
                    {
                        Kids_Menu.Margin = new Thickness(0, 21, 0, 0);
                        break;
                    };
            }
        }
        public void Kids_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var Kids = e.SelectedItem as Kids_Class;
            if (Kids != null)
            {
                if (Kids.Kids_ID.Equals("1"))
                {
                    Navigation.PushAsync(new Child_Rights());
                }
                else if (Kids.Kids_ID.Equals("2"))
                {
                    Navigation.PushAsync(new Upbringing());
                }
            }
        }
    }
    public class Kids_Class
    {
        public string Kids_ID
        {
            get;
            set;
        }
        public string Kids_Title
        {
            get;
            set;
        }
    }
}