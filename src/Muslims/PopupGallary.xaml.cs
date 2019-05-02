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

                    case "Y2010conf":
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

                    case "Y2010iftar":
                        if (i < 4)
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
                                Image_Path = pieces[0] + "_" + (i - 3) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2010uraza":
                        if (i < 7)
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
                                Image_Path = pieces[0] + "_" + (i - 6) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2010kurban":
                        if (i < 12)
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
                                Image_Path = pieces[0] + "_" + (i - 11) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2010kurban2":
                        if (i < 9)
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
                                Image_Path = pieces[0] + "_" + (i - 8) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2010mdeal":
                        if (i < 3)
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
                                Image_Path = pieces[0] + "_" + (i - 2) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2010port":
                        if (i < 7)
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
                                Image_Path = pieces[0] + "_" + (i - 6) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2011cross":
                        if (i < 8)
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
                                Image_Path = pieces[0] + "_" + (i - 7) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2011gen":
                        if (i < 6)
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
                                Image_Path = pieces[0] + "_" + (i - 5) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2011kurban":
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

                    case "Y2011pisc":
                        if (i < 6)
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
                                Image_Path = pieces[0] + "_" + (i - 5) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2011traur":
                        if (i < 12)
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
                                Image_Path = pieces[0] + "_" + (i - 11) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2011tukaev":
                        if (i < 3)
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
                                Image_Path = pieces[0] + "_" + (i - 2) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2011viborg":
                        if (i < 12)
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
                                Image_Path = pieces[0] + "_" + (i - 11) + "_.jpg"
                            };
                        }
                        break;


                    case "Y2012miting":
                        if (i < 6)
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
                                Image_Path = pieces[0] + "_" + (i - 5) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2012pisc":
                        if (i < 4)
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
                                Image_Path = pieces[0] + "_" + (i - 3) + "_.jpg"
                            };
                        }
                        break;


                    case "Y2012proshanie":
                        if (i < 14)
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
                                Image_Path = pieces[0] + "_" + (i - 13) + "_.jpg"
                            };
                        }
                        break;


                    case "Y2012sabantuy":
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

                    case "Y2012soviet":
                        if (i < 4)
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
                                Image_Path = pieces[0] + "_" + (i - 3) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2012tavrich":
                        if (i < 4)
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
                                Image_Path = pieces[0] + "_" + (i - 3) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2014":
                        if (i < 2)
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
                                Image_Path = pieces[0] + "_" + (i - 1) + "_.jpg"
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

                    case "Y2010conf":
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

                    case "Y2010iftar":
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
                                Image_Path = pieces[0] + "_" + (i + 3) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2010uraza":
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
                                Image_Path = pieces[0] + "_" + (i + 6) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2010kurban":
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
                                Image_Path = pieces[0] + "_" + (i + 11) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2010kurban2":
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
                                Image_Path = pieces[0] + "_" + (i + 8) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2010medal":
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
                                Image_Path = pieces[0] + "_" + (i + 2) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2010port":
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
                                Image_Path = pieces[0] + "_" + (i + 6) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2011cross":
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
                                Image_Path = pieces[0] + "_" + (i + 7) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2011gen":
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
                                Image_Path = pieces[0] + "_" + (i + 5) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2011kurban":
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

                    case "Y2011pisc":
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
                                Image_Path = pieces[0] + "_" + (i + 5) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2011traur":
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
                                Image_Path = pieces[0] + "_" + (i + 11) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2011tukaev":
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
                                Image_Path = pieces[0] + "_" + (i + 2) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2011viborg":
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
                                Image_Path = pieces[0] + "_" + (i + 11) + "_.jpg"
                            };
                        }
                        break;


                    case "Y2012miting":
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
                                Image_Path = pieces[0] + "_" + (i + 5) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2012pisc":
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
                                Image_Path = pieces[0] + "_" + (i + 3) + "_.jpg"
                            };
                        }
                        break;


                    case "Y2012proshanie":
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
                                Image_Path = pieces[0] + "_" + (i + 13) + "_.jpg"
                            };
                        }
                        break;


                    case "Y2012sabantuy":
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

                    case "Y2012soviet":
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
                                Image_Path = pieces[0] + "_" + (i + 3) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2012tavrich":
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
                                Image_Path = pieces[0] + "_" + (i + 3) + "_.jpg"
                            };
                        }
                        break;

                    case "Y2014":
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
                                Image_Path = pieces[0] + "_" + (i + 1) + "_.jpg"
                            };
                        }
                        break;

                }
            }
        }
    }

}