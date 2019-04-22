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
	public partial class Tukaevskie_Gallery : ContentPage
	{
		public Tukaevskie_Gallery()
		{
			InitializeComponent ();
            Gallery_Item_Init();
        }
        public void Gallery_Item_Init()
        {
            List<Gallery_Image> tuk_gallery = new List<Gallery_Image>
            {
                new Gallery_Image { Image_Path = "Y2011tukaev_1_.jpg"},
                new Gallery_Image { Image_Path = "Y2011tukaev_2_.jpg"},
                new Gallery_Image { Image_Path = "Y2011tukaev_3_.jpg"},
            };
            FlowListMenu.FlowItemsSource = tuk_gallery;
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