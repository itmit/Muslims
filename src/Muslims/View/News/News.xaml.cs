using Muslims.Models.Network;
using Muslims.ViewModel;
using Xamarin.Forms;

namespace Muslims
{
	public partial class News : TabbedPage
	{
		#region .ctor
		public News()
		{
			InitializeComponent();

			var rssFeedViewModelObject = new RssFeedViewModel(Navigation);
			rssFeedViewModelObject.SetNewsFeedAsync(new NetworkManager("http://dum-spb.ru/feed"));
			rssFeedViewModelObject.SetGazetaFeedAsync(new NetworkManagerGazeta("http://dum-spb.ru/category/gazeta/feed"));
			rssFeedViewModelObject.SetAdvertFeedAsync(new NetworkManagerAdvert("http://dum-spb.ru/category/advert/feed"));

			BindingContext = rssFeedViewModelObject;
		}
		#endregion
	}
}
