using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.LocalNotifications;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Namaz : ContentPage
	{
		public Namaz ()
		{
			InitializeComponent ();
		}
        public void Button_Click1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Order());
        }
        public void Button_Click2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Conditions());
        }
        public void Button_Click3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Perpetration());
        }
        public void Button_Click4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Namaz_Time());
           /* DateTime dt = DateTime.Now.ToLocalTime();
            int hour_only = dt.Hour;
            if (hour_only == 11)
            {
                CrossLocalNotifications.Current.Show("Время Намаза!", "Пришло время совершить Намаз!");
            }
            else
            {
                CrossLocalNotifications.Current.Show("Неверное время!", "Неверное время!");
            }*/
        }
        public void Button_Click5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Prayers());
        }
    }
}