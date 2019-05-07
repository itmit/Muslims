using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Y2011 : ContentPage
	{
		#region .ctor
		public Y2011()
		{
			InitializeComponent();
		}
		#endregion

		#region Public
		public void Button_Click1(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Cross_Gallery());
		}

		public void Button_Click2(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Gen_Gallery());
		}

		public void Button_Click3(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Traur_Gallery());
		}

		public void Button_Click4(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Viborg_Galley());
		}

		public void Button_Click5(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Pisc_Gallery());
		}

		public void Button_Click6(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Kurban2011_Gallery());
		}

		public void Button_Click7(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Tukaevskie_Gallery());
		}
		#endregion
	}
}
