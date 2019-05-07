using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Muslims.Models;
using Muslims.Parser;
using Plugin.Connectivity;

namespace Muslims.Network
{
	public sealed class NetworkManagerGazeta
	{
		#region Data
		#region Static
		public static NetworkManagerGazeta network_manager_gazeta = new NetworkManagerGazeta();
		public static string network_url = "http://dum-spb.ru/category/gazeta/feed";
		#endregion
		#endregion

		#region .ctor
		private NetworkManagerGazeta()
		{
		}
		#endregion

		#region Properties
		public static NetworkManagerGazeta Instance => network_manager_gazeta;
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
				var parser = new GazetaParser();
				// List<FeedItem> list = await Task.Run(() => parser.ParseFeed(response_string));
				var gazetalist = await Task.Run(() => parser.ParseFeed(response_string));
				return gazetalist;
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
