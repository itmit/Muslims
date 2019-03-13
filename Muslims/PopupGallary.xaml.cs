using Rg.Plugins.Popup.Pages;
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
	public partial class PopupGallary : PopupPage
	{
		public PopupGallary ()
		{
			InitializeComponent ();
		}
        public string SomeImage
        {
            get { return string.Format("spb_1_1.jpg"); }
        }
        private async void ItemTappedCommand(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync(true);
        }

    }
}