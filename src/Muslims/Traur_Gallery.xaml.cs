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
	public partial class Traur_Gallery : ContentPage
	{
		public Traur_Gallery()
		{
			InitializeComponent ();
            Gallery_Item_Init();
        }
        public void Gallery_Item_Init()
        {
            List<Gallery_Image> traur_gallery = new List<Gallery_Image>
            {
                new Gallery_Image { Image_Path = "Y2011traur_1_.jpg"},
                new Gallery_Image { Image_Path = "Y2011traur_2_.jpg"},
                new Gallery_Image { Image_Path = "Y2011traur_3_.jpg"},
                new Gallery_Image { Image_Path = "Y2011traur_4_.jpg"},
                new Gallery_Image { Image_Path = "Y2011traur_5_.jpg"},
                new Gallery_Image { Image_Path = "Y2011traur_6_.jpg"},
                new Gallery_Image { Image_Path = "Y2011traur_7_.jpg"},
                new Gallery_Image { Image_Path = "Y2011traur_8_.jpg"},
                new Gallery_Image { Image_Path = "Y2011traur_9_.jpg"},
            };
            FlowListMenu.FlowItemsSource = traur_gallery;
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