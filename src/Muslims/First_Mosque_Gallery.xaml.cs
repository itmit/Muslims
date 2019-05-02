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
	public partial class First_Mosque_Gallery : ContentPage
	{
		public First_Mosque_Gallery()
		{
			InitializeComponent();
            Gallery_Item_Init();

        }
        public void Gallery_Item_Init()
        {
            List<Gallery_Image> gallery = new List<Gallery_Image>
            {
                new Gallery_Image { Image_ID ="1", Image_Path = "spb_1_.jpg"},
                new Gallery_Image { Image_ID ="2", Image_Path = "spb_2_.jpg"},
                new Gallery_Image { Image_ID ="3", Image_Path = "spb_3_.jpg"},
                new Gallery_Image { Image_ID ="4", Image_Path = "spb_4_.jpg"},
                new Gallery_Image { Image_ID ="5", Image_Path = "spb_5_.jpg"},
                new Gallery_Image { Image_ID ="6", Image_Path = "spb_6_.jpg"},
                new Gallery_Image { Image_ID ="7", Image_Path = "spb_7_.jpg"},
                new Gallery_Image { Image_ID ="8", Image_Path = "spb_8_.jpg"},
                new Gallery_Image { Image_ID ="9", Image_Path = "spb_9_.jpg"},
                new Gallery_Image { Image_ID ="10", Image_Path = "spb_10_.jpg"},
                new Gallery_Image { Image_ID ="11", Image_Path = "spb_11_.jpg"},
                new Gallery_Image { Image_ID ="12", Image_Path = "spb_12_.jpg"},
                new Gallery_Image { Image_ID ="13", Image_Path = "spb_13_.jpg"},
                new Gallery_Image { Image_ID ="14", Image_Path = "spb_14_.jpg"},
                new Gallery_Image { Image_ID ="15", Image_Path = "spb_15_.jpg"},
                new Gallery_Image { Image_ID ="16", Image_Path = "spb_16_.jpg"},
                new Gallery_Image { Image_ID ="17", Image_Path = "spb_17_.jpg"},
                new Gallery_Image { Image_ID ="18", Image_Path = "spb_18_.jpg"},
                new Gallery_Image { Image_ID ="19", Image_Path = "spb_19_.jpg"},
                new Gallery_Image { Image_ID ="20", Image_Path = "spb_20_.jpg"},
                new Gallery_Image { Image_ID ="21", Image_Path = "spb_21_.jpg"},
                new Gallery_Image { Image_ID ="22", Image_Path = "spb_22_.jpg"},
                new Gallery_Image { Image_ID ="23", Image_Path = "spb_23_.jpg"},
                new Gallery_Image { Image_ID ="24", Image_Path = "spb_24_.jpg"},
                new Gallery_Image { Image_ID ="25", Image_Path = "spb_25_.jpg"},
                new Gallery_Image { Image_ID ="26", Image_Path = "spb_26_.jpg"},
                new Gallery_Image { Image_ID ="27", Image_Path = "spb_27_.jpg"},
                new Gallery_Image { Image_ID ="28", Image_Path = "spb_28_.jpg"},
                new Gallery_Image { Image_ID ="29", Image_Path = "spb_29_.jpg"},
                new Gallery_Image { Image_ID ="30", Image_Path = "spb_30_.jpg"},
            };
            FlowListMenu.FlowItemsSource = gallery;
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
    public class Gallery_Image
    {
        public string Image_Path
        {
            get;
            set;
        }
        public string Image_ID
        {
            get;
            set;
        }
    }
}