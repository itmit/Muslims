using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Muslims.Models;
using Muslims.Parser;
using Plugin.Connectivity;

namespace Muslims.Network
{
	public sealed class NetworkManager
	{
		#region Data
		#region Static
		public static NetworkManager network_manager = new NetworkManager();
		public static string network_url = "http://dum-spb.ru/feed";
		#endregion
		#endregion

		#region .ctor
		private NetworkManager()
		{
		}
		#endregion

		#region Properties
		public static NetworkManager Instance => network_manager;
		#endregion

		#region Public
		public async Task<List<NewsItem>> GetSyncFeedAsync()
		{
			if (IsConnected())
			{
				var uri = new Uri(network_url);
				var client = new HttpClient();
				var response = await client.GetAsync(uri);
				var responseString = await response.Content.ReadAsStringAsync();
				var parser = new NewsParser();

				var list = await Task.Run(() => parser.ParseFeed(responseString));
				return list;
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
