using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Gallery_1 : ContentPage
	{
		public Gallery_1 ()
		{
			InitializeComponent ();
            Gallery_Item_Init();

        }
        public void Gallery_Item_Init()
        {
            List<Gallery> gallery = new List<Gallery>
            {
                new Gallery { Image = "spb_1_1.jpg"},
                new Gallery { Image = "spb_1_2.jpg"},
                new Gallery { Image = "spb_1_3.jpg"},
                new Gallery { Image = "spb_1_4.jpg"},
                new Gallery { Image = "spb_1_5.jpg"},
                new Gallery { Image = "spb_1_6.jpg"},
                new Gallery { Image = "spb_1_7.jpg"},
                new Gallery { Image = "spb_1_8.jpg"},
                new Gallery { Image = "spb_1_9.jpg"},
                new Gallery { Image = "spb_1_10.jpg"},
                new Gallery { Image = "spb_1_11.jpg"},
                new Gallery { Image = "spb_1_12.jpg"},
                new Gallery { Image = "spb_1_13.jpg"},
                new Gallery { Image = "spb_1_14.jpg"},
                new Gallery { Image = "spb_1_15.jpg"},
                new Gallery { Image = "spb_1_16.jpg"},
                new Gallery { Image = "spb_1_17.jpg"},
                new Gallery { Image = "spb_1_18.jpg"},
                new Gallery { Image = "spb_1_19.jpg"},
                new Gallery { Image = "spb_1_20.jpg"},
                new Gallery { Image = "spb_1_21.jpg"},
                new Gallery { Image = "spb_1_22.jpg"},
                new Gallery { Image = "spb_1_23.jpg"},
                new Gallery { Image = "spb_1_24.jpg"},
                new Gallery { Image = "spb_1_25.jpg"},
                new Gallery { Image = "spb_1_26.jpg"},
                new Gallery { Image = "spb_1_27.jpg"},
                new Gallery { Image = "spb_1_28.jpg"},
                new Gallery { Image = "spb_1_29.jpg"},
                new Gallery { Image = "spb_1_30.jpg"},
            };

            FlowListMenu.FlowItemsSource = gallery;
        }
        public async void ItemTappedCommand(object sender, EventArgs e)
        { 
            await PopupNavigation.Instance.PushAsync(new PopupGallary());
        }


    }
    public class Gallery
    {
        public string Image
        {
            get;
            set;
        }
    }
}