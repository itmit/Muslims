using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Muslims.Models;
using Muslims.Parser;
using Plugin.Connectivity;

namespace Muslims.Network
{
	public sealed class NetworkManagerAdvert
	{
		#region Data
		#region Static
		public static NetworkManagerAdvert network_manager_advert = new NetworkManagerAdvert();
		public static string network_url = "http://dum-spb.ru/category/advert/feed";
		#endregion
		#endregion

		#region .ctor
		private NetworkManagerAdvert()
		{
		}
		#endregion

		#region Properties
		public static NetworkManagerAdvert Instance => network_manager_advert;
		#endregion

		#region Public
		public async Task<List<NewsItem>> GetSyncFeedAsync()
		{
			if (IsConnected())
			{
				var uri = new Uri(network_url);
				var client = new HttpClient();
				var response = await client.GetAsync(uri);
				var response_string = await response.Content.ReadAsStringAsync();
				var parser = new AdvertParser();
				// List<FeedItem> list = await Task.Run(() => parser.ParseFeed(response_string));
				var advertlist = await Task.Run(() => parser.ParseFeed(response_string));
				return advertlist;
			}

			return null;
		}

		public bool IsConnected()
		{
			if (CrossConnectivity.Current.IsConnected)
			{
				return true;
			}

			return false;
		}
		#endregion
	}
}
