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
	public partial class Conference_Gallery : ContentPage
	{
		public Conference_Gallery()
		{
			InitializeComponent ();
            Gallery_Item_Init();
        }
        public void Gallery_Item_Init()
        {
            List<Gallery_Image> conf_gallery = new List<Gallery_Image>
            {
                new Gallery_Image { Image_Path = "Y2010conf_1_.jpg"},
                new Gallery_Image { Image_Path = "Y2010conf_2_.jpg"},
                new Gallery_Image { Image_Path = "Y2010conf_3_.jpg"},
                new Gallery_Image { Image_Path = "Y2010conf_4_.jpg"},
                new Gallery_Image { Image_Path = "Y2010conf_5_.jpg"},
                new Gallery_Image { Image_Path = "Y2010conf_6_.jpg"},
                new Gallery_Image { Image_Path = "Y2010conf_7_.jpg"},
                new Gallery_Image { Image_Path = "Y2010conf_8_.jpg"},
                new Gallery_Image { Image_Path = "Y2010conf_9_.jpg"},
                new Gallery_Image { Image_Path = "Y2010conf_10_.jpg"},

            };
            FlowListMenu.FlowItemsSource = conf_gallery;
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