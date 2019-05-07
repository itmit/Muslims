using System;
using System.Collections.Generic;
using Muslims.Models;
using Muslims.Network;
using Muslims.ViewModel;
using Xamarin.Forms;

namespace Muslims
{
    public partial class News : TabbedPage
    {
		public News()
        {
			InitializeComponent();

			var rssFeedViewModelObject = new RSSFeedViewModel(Navigation);
			rssFeedViewModelObject.SetNewsFeedAsync(NetworkManager.Instance);
			rssFeedViewModelObject.SetGazetaFeedAsync(NetworkManagerGazeta.Instance);
			rssFeedViewModelObject.SetAdvertFeedAsync(NetworkManagerAdvert.Instance);

			BindingContext = rssFeedViewModelObject;
		}

    }
}
