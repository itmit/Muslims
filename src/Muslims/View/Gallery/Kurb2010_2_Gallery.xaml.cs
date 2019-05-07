using System;
using System.Collections.Generic;
using FFImageLoading.Forms;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Kurb2010_2_Gallery : ContentPage
	{
		#region .ctor
		public Kurb2010_2_Gallery()
		{
			InitializeComponent();
			Gallery_Item_Init();
		}
		#endregion

		#region Public
		public void Gallery_Item_Init()
		{
			var kurb2_gallery = new List<Gallery_Image>
			{
				new Gallery_Image
				{
					Image_Path = "Y2010kurban2_1_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2010kurban2_2_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2010kurban2_3_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2010kurban2_4_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2010kurban2_5_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2010kurban2_6_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2010kurban2_7_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2010kurban2_8_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2010kurban2_9_.jpg"
				}
			};
			FlowListMenu.FlowItemsSource = kurb2_gallery;
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
