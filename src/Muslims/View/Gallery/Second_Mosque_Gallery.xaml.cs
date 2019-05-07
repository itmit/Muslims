using System;
using System.Collections.Generic;
using FFImageLoading.Forms;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Second_Mosque_Gallery : ContentPage
	{
		#region .ctor
		public Second_Mosque_Gallery()
		{
			InitializeComponent();
			Gallery_Item_Init();
		}
		#endregion

		#region Public
		public void Gallery_Item_Init()
		{
			var second_gallery = new List<Gallery_Image>
			{
				new Gallery_Image
				{
					Image_Path = "spbt_1_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_2_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_3_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_4_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_5_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_6_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_7_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_8_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_9_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_10_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_11_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_12_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_13_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_14_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_15_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_16_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_17_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_18_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_19_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_20_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_21_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_22_.jpg"
				},
				new Gallery_Image
				{
					Image_Path = "spbt_23_.jpg"
				}
			};
			FlowListMenu.FlowItemsSource = second_gallery;
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
