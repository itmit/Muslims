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
	public partial class Pisc_Gallery : ContentPage
	{
		public Pisc_Gallery()
		{
			InitializeComponent ();
            Gallery_Item_Init();
        }
        public void Gallery_Item_Init()
        {
            List<Gallery_Image> pisc_gallery = new List<Gallery_Image>
            {
                new Gallery_Image { Image_Path = "Y2011pisc_1_.jpg"},
                new Gallery_Image { Image_Path = "Y2011pisc_2_.jpg"},
                new Gallery_Image { Image_Path = "Y2011pisc_3_.jpg"},
                new Gallery_Image { Image_Path = "Y2011pisc_4_.jpg"},
                new Gallery_Image { Image_Path = "Y2011pisc_5_.jpg"},
                new Gallery_Image { Image_Path = "Y2011pisc_6_.jpg"},
            };
            FlowListMenu.FlowItemsSource = pisc_gallery;
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