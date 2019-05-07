using System;
using System.Collections.Generic;
using FFImageLoading.Forms;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Y2013_Gallery : ContentPage
	{
		#region .ctor
		public Y2013_Gallery()
		{
			InitializeComponent();
			Gallery_Item_Init();
		}
		#endregion

		#region Public
		public void Gallery_Item_Init()
		{
			var Y13_gallery = new List<Gallery_Image>
			{
				new Gallery_Image
				{
					Image_Path = "Y2013_1_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2013_2_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2013_3_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2013_4_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2013_5_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2013_6_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2013_7_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2013_8_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2013_9_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2013_10_.jpg"
				}
			};
			FlowListMenu.FlowItemsSource = Y13_gallery;
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
