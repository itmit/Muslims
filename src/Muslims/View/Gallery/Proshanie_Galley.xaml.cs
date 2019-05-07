using System;
using System.Collections.Generic;
using FFImageLoading.Forms;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Proshanie_Galley : ContentPage
	{
		#region .ctor
		public Proshanie_Galley()
		{
			InitializeComponent();
			Gallery_Item_Init();
		}
		#endregion

		#region Public
		public void Gallery_Item_Init()
		{
			var prosh_gallery = new List<Gallery_Image>
			{
				new Gallery_Image
				{
					Image_Path = "Y2012proshanie_1_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2012proshanie_2_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2012proshanie_3_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2012proshanie_4_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2012proshanie_5_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2012proshanie_6_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2012proshanie_7_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2012proshanie_8_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2012proshanie_9_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2012proshanie_10_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2012proshanie_11_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2012proshanie_12_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2012proshanie_13_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2012proshanie_14_.jpg"
				}
			};
			FlowListMenu.FlowItemsSource = prosh_gallery;
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
