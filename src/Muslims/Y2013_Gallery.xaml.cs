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
    public partial class  Y2013_Gallery : ContentPage
    {
        public Y2013_Gallery()
        {
            InitializeComponent();
            Gallery_Item_Init();

        }
        public void Gallery_Item_Init()
        {
            List<Gallery_Image> Y13_gallery = new List<Gallery_Image>
            {
                new Gallery_Image { Image_Path = "Y2013_1_.jpg"},
                new Gallery_Image { Image_Path = "Y2013_2_.jpg"},
                new Gallery_Image { Image_Path = "Y2013_3_.jpg"},
                new Gallery_Image { Image_Path = "Y2013_4_.jpg"},
                new Gallery_Image { Image_Path = "Y2013_5_.jpg"},
                new Gallery_Image { Image_Path = "Y2013_6_.jpg"},
                new Gallery_Image { Image_Path = "Y2013_7_.jpg"},
                new Gallery_Image { Image_Path = "Y2013_8_.jpg"},
                new Gallery_Image { Image_Path = "Y2013_9_.jpg"},
                new Gallery_Image { Image_Path = "Y2013_10_.jpg"}

            };
            FlowListMenu.FlowItemsSource = Y13_gallery;
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