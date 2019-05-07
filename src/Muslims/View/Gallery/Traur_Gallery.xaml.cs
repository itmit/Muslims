﻿using System;
using System.Collections.Generic;
using FFImageLoading.Forms;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Traur_Gallery : ContentPage
	{
		#region .ctor
		public Traur_Gallery()
		{
			InitializeComponent();
			Gallery_Item_Init();
		}
		#endregion

		#region Public
		public void Gallery_Item_Init()
		{
			var traur_gallery = new List<Gallery_Image>
			{
				new Gallery_Image
				{
					Image_Path = "Y2011traur_1_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2011traur_2_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2011traur_3_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2011traur_4_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2011traur_5_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2011traur_6_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2011traur_7_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2011traur_8_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2011traur_9_.jpg"
				}
			};
			FlowListMenu.FlowItemsSource = traur_gallery;
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