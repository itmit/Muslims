using System;
using System.Collections.Generic;
using FFImageLoading.Forms;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims.View.Gallery
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConferenceGallery : ContentPage
	{
		#region .ctor
		public ConferenceGallery()
		{
			InitializeComponent();
			GalleryItemInit();
		}
		#endregion

		#region Public
		private void GalleryItemInit()
		{
			var confGallery = new List<Gallery_Image>
			{
				new Gallery_Image
				{
					Image_Path = "Y2010conf_1_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2010conf_2_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2010conf_3_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2010conf_4_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2010conf_5_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2010conf_6_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2010conf_7_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2010conf_8_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2010conf_9_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2010conf_10_.jpg"
				}
			};
			FlowListMenu.FlowItemsSource = confGallery;
		}

		public async void ItemTappedCommand(object sender, EventArgs e)
		{
			if (sender is CachedImage img)
			{
				var fileImageSource = (FileImageSource) img.Source;
				var strFileName = fileImageSource.File;
				await PopupNavigation.Instance.PushAsync(new PopupGallary(strFileName));
			}
		}
		#endregion
	}
}
