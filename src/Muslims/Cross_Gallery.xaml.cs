using System;
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
	public partial class Cross_Gallery : ContentPage
	{
		public Cross_Gallery()
		{
			InitializeComponent ();
            Gallery_Item_Init();
        }
        public void Gallery_Item_Init()
        {
            List<Gallery_Image> cross_gallery = new List<Gallery_Image>
            {
                new Gallery_Image { Image_Path = "Y2011cross_1_.jpg"},
                new Gallery_Image { Image_Path = "Y2011cross_2_.jpg"},
                new Gallery_Image { Image_Path = "Y2011cross_3_.jpg"},
                new Gallery_Image { Image_Path = "Y2011cross_4_.jpg"},
                new Gallery_Image { Image_Path = "Y2011cross_5_.jpg"},
                new Gallery_Image { Image_Path = "Y2011cross_6_.jpg"},
                new Gallery_Image { Image_Path = "Y2011cross_7_.jpg"},
                new Gallery_Image { Image_Path = "Y2011cross_8_.jpg"},

            };
            FlowListMenu.FlowItemsSource = cross_gallery;
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