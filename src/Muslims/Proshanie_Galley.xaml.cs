﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Proshanie_Galley : ContentPage
	{
		public Proshanie_Galley()
		{
			InitializeComponent ();
            Gallery_Item_Init();
        }
        public void Gallery_Item_Init()
        {
            List<Gallery_Image> prosh_gallery = new List<Gallery_Image>
            {
                new Gallery_Image { Image_Path = "Y2012proshanie_1_.jpg"},
                new Gallery_Image { Image_Path = "Y2012proshanie_2_.jpg"},
                new Gallery_Image { Image_Path = "Y2012proshanie_3_.jpg"},
                new Gallery_Image { Image_Path = "Y2012proshanie_4_.jpg"},
                new Gallery_Image { Image_Path = "Y2012proshanie_5_.jpg"},
                new Gallery_Image { Image_Path = "Y2012proshanie_6_.jpg"},
                new Gallery_Image { Image_Path = "Y2012proshanie_7_.jpg"},
                new Gallery_Image { Image_Path = "Y2012proshanie_8_.jpg"},
                new Gallery_Image { Image_Path = "Y2012proshanie_9_.jpg"},
                new Gallery_Image { Image_Path = "Y2012proshanie_10_.jpg"},
                new Gallery_Image { Image_Path = "Y2012proshanie_11_.jpg"},
                new Gallery_Image { Image_Path = "Y2012proshanie_12_.jpg"},
                new Gallery_Image { Image_Path = "Y2012proshanie_13_.jpg"},
                new Gallery_Image { Image_Path = "Y2012proshanie_14_.jpg"},

            };
            FlowListMenu.FlowItemsSource = prosh_gallery;
        }
        public async void ItemTappedCommand(object sender, EventArgs e)
        {
            if (sender is FFImageLoading.Forms.CachedImage img)
            {
                FileImageSource FileImageSource = (FileImageSource)img.Source;
                string strFileName = FileImageSource.File;
                await PopupNavigation.Instance.PushAsync(new PopupGallary(strFileName));
            }
        }
    }
}