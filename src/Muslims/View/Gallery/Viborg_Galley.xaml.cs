using System;
using System.Collections.Generic;
using FFImageLoading.Forms;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Viborg_Galley : ContentPage
	{
		#region .ctor
		public Viborg_Galley()
		{
			InitializeComponent();
			Gallery_Item_Init();
		}
		#endregion

		#region Public
		public void Gallery_Item_Init()
		{
			var viborg_gallery = new List<Gallery_Image>
			{
				new Gallery_Image
				{
					Image_Path = "Y2011viborg_1_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2011viborg_2_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2011viborg_3_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2011viborg_4_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2011viborg_5_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2011viborg_6_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2011viborg_7_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2011viborg_8_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "Y2011viborg_9_.jpg"
				}
			};
			FlowListMenu.FlowItemsSource = viborg_gallery;
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
