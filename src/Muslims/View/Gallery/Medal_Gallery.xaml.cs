using System;
using System.Collections.Generic;
using FFImageLoading.Forms;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Medal_Gallery : ContentPage
	{
		#region .ctor
		public Medal_Gallery()
		{
			InitializeComponent();
			Gallery_Item_Init();
		}
		#endregion

		#region Public
		public void Gallery_Item_Init()
		{
			var md_gallery = new List<Gallery_Image>
			{
				new Gallery_Image
				{
					Image_Path = "Y2010mdeal_1_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2010mdeal_2_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2010mdeal_3_.jpg"
				}
			};
			FlowListMenu.FlowItemsSource = md_gallery;
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
