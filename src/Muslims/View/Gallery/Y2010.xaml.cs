using System;
using Muslims.View.Gallery;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Y2010 : ContentPage
	{
		#region .ctor
		public Y2010()
		{
			InitializeComponent();
		}
		#endregion

		#region Public
		public void Button_Click1(object sender, EventArgs e)
		{
			Navigation.PushAsync(new ConferenceGallery());
		}

		public void Button_Click2(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Iftar_Gallery());
		}

		public void Button_Click3(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Uraza_Gallery());
		}

		public void Button_Click4(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Kurb2010_1_Gallery());
		}

		public void Button_Click5(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Kurb2010_2_Gallery());
		}

		public void Button_Click6(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Medal_Gallery());
		}

		public void Button_Click7(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Port_Gallery());
		}
		#endregion
	}
}
