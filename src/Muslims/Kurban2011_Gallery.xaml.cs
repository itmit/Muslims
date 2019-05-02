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
	public partial class Kurban2011_Gallery : ContentPage
	{
		public Kurban2011_Gallery()
		{
			InitializeComponent ();
            Gallery_Item_Init();
        }
        public void Gallery_Item_Init()
        {
            List<Gallery_Image> kurb11_gallery = new List<Gallery_Image>
            {
                new Gallery_Image { Image_Path = "Y2011kurban_1_.jpg"},
                new Gallery_Image { Image_Path = "Y2011kurban_2_.jpg"},
                new Gallery_Image { Image_Path = "Y2011kurban_3_.jpg"},
                new Gallery_Image { Image_Path = "Y2011kurban_4_.jpg"},
                new Gallery_Image { Image_Path = "Y2011kurban_5_.jpg"},
            };
            FlowListMenu.FlowItemsSource = kurb11_gallery;
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