﻿using System;
using System.Collections.Generic;
using FFImageLoading.Forms;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pisc2012_Galley : ContentPage
	{
		#region .ctor
		public Pisc2012_Galley()
		{
			InitializeComponent();
			Gallery_Item_Init();
		}
		#endregion

		#region Public
		public void Gallery_Item_Init()
		{
			var conf_gallery = new List<Gallery_Image>
			{
				new Gallery_Image
				{
					Image_Path = "Y2012pisc_1_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2012pisc_2_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2012pisc_3_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2012pisc_4_.jpg"
				}
			};
			FlowListMenu.FlowItemsSource = conf_gallery;
		}

		public async void ItemTappedCommand(object sender, EventArgs e)
		{
			if (sender is CachedImage img)
			{
				var FileImageSource = (FileImageSource) img.Source;
				var strFileName = FileImageSource.File;
				await PopupNavigation.Instance.PushAsync(new PopupGallary(strFileName));
			}
		}
		#endregion
	}
}