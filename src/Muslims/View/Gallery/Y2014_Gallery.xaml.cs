using System;
using System.Collections.Generic;
using FFImageLoading.Forms;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Y2014_Gallery : ContentPage
	{
		#region .ctor
		public Y2014_Gallery()
		{
			InitializeComponent();
			Gallery_Item_Init();
		}
		#endregion

		#region Public
		public void Gallery_Item_Init()
		{
			var y2014_gallery = new List<Gallery_Image>
			{
				new Gallery_Image
				{
					Image_Path = "Y2014_1_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2014_2_.jpg"
				}
			};
			FlowListMenu.FlowItemsSource = y2014_gallery;
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
