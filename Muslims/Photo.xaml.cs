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
            Navigation.PushAsync(new Gallery_1());
        }
    }
}