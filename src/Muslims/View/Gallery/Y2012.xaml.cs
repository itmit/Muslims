using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Y2012 : ContentPage
	{
		#region .ctor
		public Y2012()
		{
			InitializeComponent();
		}
		#endregion

		#region Public
		public void Button_Click1(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Pisc2012_Galley());
		}

		public void Button_Click2(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Miting_Gallery());
		}

		public void Button_Click3(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Sabantuy_Gallery());
		}

		public void Button_Click4(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Tavricheskiy_Gallery());
		}

		public void Button_Click5(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Soviet_Gallery());
		}

		public void Button_Click6(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Proshanie_Galley());
		}
		#endregion
	}
}
