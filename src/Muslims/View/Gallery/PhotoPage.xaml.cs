﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims.View.Gallery
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PhotoPage : ContentPage
	{
		#region .ctor
		public PhotoPage()
		{
			InitializeComponent();
		}
		#endregion

		#region Public
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

		public void Button_Click4(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Y2010());
		}

		public void Button_Click5(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Y2011());
		}

		public void Button_Click6(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Y2012());
		}

		public void Button_Click7(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Y2013_Gallery());
		}

		public void Button_Click8(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Y2014_Gallery());
		}
		#endregion
	}
}
