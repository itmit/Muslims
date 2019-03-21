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
	public partial class Photo : ContentPage
	{
		public Photo ()
		{
			InitializeComponent ();
		}
        public void Button_Click1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new First_Mosque_Gallery());
        }
        public void Button_Click2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Second_Mosque_Gallery());
        }
        public void Button_Click3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Kurban_Gallery());
        }
        public void Button_Click7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Y2013_Gallery());
        }
    }
}