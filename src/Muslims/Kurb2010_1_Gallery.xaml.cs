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
	public partial class Kurb2010_1_Gallery : ContentPage
	{
		public Kurb2010_1_Gallery()
		{
			InitializeComponent ();
            Gallery_Item_Init();
        }
        public void Gallery_Item_Init()
        {
            List<Gallery_Image> kurb1_gallery = new List<Gallery_Image>
            {
                new Gallery_Image { Image_Path = "Y2010kurban_1_.jpg"},
                new Gallery_Image { Image_Path = "Y2010kurban_2_.jpg"},
                new Gallery_Image { Image_Path = "Y2010kurban_3_.jpg"},
                new Gallery_Image { Image_Path = "Y2010kurban_4_.jpg"},
                new Gallery_Image { Image_Path = "Y2010kurban_5_.jpg"},
                new Gallery_Image { Image_Path = "Y2010kurban_6_.jpg"},
                new Gallery_Image { Image_Path = "Y2010kurban_7_.jpg"},
                new Gallery_Image { Image_Path = "Y2010kurban_8_.jpg"},
                new Gallery_Image { Image_Path = "Y2010kurban_9_.jpg"},
                new Gallery_Image { Image_Path = "Y2010kurban_10_.jpg"},
                new Gallery_Image { Image_Path = "Y2010kurban_11_.jpg"},
                new Gallery_Image { Image_Path = "Y2010kurban_12_.jpg"},

            };
            FlowListMenu.FlowItemsSource = kurb1_gallery;
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