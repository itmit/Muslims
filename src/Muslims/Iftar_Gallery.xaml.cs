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
	public partial class Iftar_Gallery : ContentPage
	{
		public Iftar_Gallery()
		{
			InitializeComponent ();
            Gallery_Item_Init();
        }
        public void Gallery_Item_Init()
        {
            List<Gallery_Image> iftar_gallery = new List<Gallery_Image>
            {
                new Gallery_Image { Image_Path = "Y2010iftar_1_.jpg"},
                new Gallery_Image { Image_Path = "Y2010iftar_2_.jpg"},
                new Gallery_Image { Image_Path = "Y2010iftar_3_.jpg"},
                new Gallery_Image { Image_Path = "Y2010iftar_4_.jpg"},

            };
            FlowListMenu.FlowItemsSource = iftar_gallery;
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