using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopupGallary : PopupPage
	{
		public PopupGallary(string imageSource)
		{
			InitializeComponent ();
            this.BindingContext = new Gallery_Image
            {
                Image_Path = imageSource
            };
		}
        private async void ItemTappedCommand(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync(true);
        }
        public void LeftSwiped(object sender, EventArgs e)
        {
            if (sender is Image img)
            {
                FileImageSource FileImageSource = (FileImageSource)img.Source;
                string strFileName = FileImageSource.File;
                string[] pieces = strFileName.Split('_');
                int i = Int32.Parse(pieces[1]);

                switch(pieces[0])
                {
                    case "spb":
                        if (i < 30)
                        {
                            this.BindingContext = new Gallery_Image
                            {
                                Image_Path = pieces[0] + "_" + (i + 1) + "_.jpg"
                            };
                        }
                        else
                        {
                            this.BindingContext = new Gallery_Image
                            {
                                Image_Path = pieces[0] + "_" + (i - 29) + "_.jpg"
                            };
                        }
                        break;

                    case "spbt":
                        if (i < 23)
                        {
                            this.BindingContext = new Gallery_Image
                            {
                                Image_Path = pieces[0] + "_" + (i + 1) + "_.jpg"
                            };
                        }
                        else
                        {
                            this.BindingContext = new Gallery_Image
                            {
                                Image_Path = pieces[0] + "_" + (i - 22) + "_.jpg"
                            };
                        }
                        break;

                    case "kurb":
                        if (i < 5)
                        {
                            this.BindingContext = new Gallery_Image
                            {
                                Image_Path = pieces[0] + "_" + (i + 1) + "_.jpg"
                            };
                        }
                        else
                        {
                            this.BindingContext = new Gallery_Image
                            {
                                Image_Path = pieces[0] + "_" + (i - 4) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2013":
                        if (i < 10)
                        {
                            this.BindingContext = new Gallery_Image
                            {
                                Image_Path = pieces[0] + "_" + (i + 1) + "_.jpg"
                            };
                        }
                        else
                        {
                            this.BindingContext = new Gallery_Image
                            {
                                Image_Path = pieces[0] + "_" + (i - 9) + "_.jpg"
                            };
                        }
                        break;

                }
            }    
        }
        public void RightSwiped(object sender, EventArgs e)
        {
            if (sender is Image img)
            {
                FileImageSource FileImageSource = (FileImageSource)img.Source;
                string strFileName = FileImageSource.File;
                string[] pieces = strFileName.Split('_');
                int i = Int32.Parse(pieces[1]);

                switch (pieces[0])
                {
                    case "spb":
                        if (i > 1)
                        {
                            this.BindingContext = new Gallery_Image
                            {
                                Image_Path = pieces[0] + "_" + (i - 1) + "_.jpg"
                            };
                        }
                        else
                        {
                            this.BindingContext = new Gallery_Image
                            {
                                Image_Path = pieces[0] + "_" + (i + 29) + "_.jpg"
                            };
                        }
                        break;

                    case "spbt":
                        if (i > 1)
                        {
                            this.BindingContext = new Gallery_Image
                            {
                                Image_Path = pieces[0] + "_" + (i - 1) + "_.jpg"
                            };
                        }
                        else
                        {
                            this.BindingContext = new Gallery_Image
                            {
                                Image_Path = pieces[0] + "_" + (i + 22) + "_.jpg"
                            };
                        }
                        break;

                    case "kurb":
                        if (i > 1)
                        {
                            this.BindingContext = new Gallery_Image
                            {
                                Image_Path = pieces[0] + "_" + (i - 1) + "_.jpg"
                            };
                        }
                        else
                        {
                            this.BindingContext = new Gallery_Image
                            {
                                Image_Path = pieces[0] + "_" + (i + 4) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2013":
                        if (i > 1)
                        {
                            this.BindingContext = new Gallery_Image
                            {
                                Image_Path = pieces[0] + "_" + (i - 1) + "_.jpg"
                            };
                        }
                        else
                        {
                            this.BindingContext = new Gallery_Image
                            {
                                Image_Path = pieces[0] + "_" + (i + 9) + "_.jpg"
                            };
                        }
                        break;

                }
            }
        }
    }

}