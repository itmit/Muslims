using System;
using System.Collections.Generic;
using FFImageLoading.Forms;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Tavricheskiy_Gallery : ContentPage
	{
		#region .ctor
		public Tavricheskiy_Gallery()
		{
			InitializeComponent();
			Gallery_Item_Init();
		}
		#endregion

		#region Public
		public void Gallery_Item_Init()
		{
			var tavr_gallery = new List<Gallery_Image>
			{
				new Gallery_Image
				{
					Image_Path = "Y2012tavrich_1_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2012tavrich_2_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2012tavrich_3_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2012tavrich_4_.jpg"
				}
			};
			FlowListMenu.FlowItemsSource = tavr_gallery;
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
