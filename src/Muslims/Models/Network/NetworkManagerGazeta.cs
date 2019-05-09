using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Muslims.Models.Parser;
using Plugin.Connectivity;

namespace Muslims.Models.Network
{
	public sealed class NetworkManagerGazeta
	{
		#region Data
		private readonly string _networkUrl;

		#endregion

		#region .ctor
		public NetworkManagerGazeta(string networkUrl)
		{
			_networkUrl = networkUrl;
		}
		#endregion

		#region Public
		public async Task<List<NewsItem>> GetSyncFeedAsync()
		{
			if (CrossConnectivity.Current.IsConnected)
			{
				var uri = new Uri(_networkUrl);
				var client = new HttpClient();
				var response = await client.GetAsync(uri);
				var responseString = await response.Content.ReadAsStringAsync();
				var parser = new GazetaParser();

				var gazetaList = await Task.Run(() => parser.ParseFeed(responseString));
				return gazetaList;
			}

			return null;
		}
		#endregion
	}
}
