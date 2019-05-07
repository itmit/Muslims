using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Net.Http;
using System.Threading.Tasks;
using Plugin.Connectivity;
using Muslims.Models;
using Muslims.Parser;
using Muslims;

namespace Muslims.Network
{
    public sealed class NetworkManager
    {
        public static NetworkManager network_manager = new NetworkManager();
        public static string network_url = "http://dum-spb.ru/feed";

        private NetworkManager()
        {
        }

        public static NetworkManager Instance
        {
            get
            {
                return network_manager;
            }
        }

        public async Task<List<NewsItem>> GetSyncFeedAsync()
        {
            if (this.IsConnected())
            {
                Uri uri = new Uri(network_url);
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(uri);
                String responseString = await response.Content.ReadAsStringAsync();
                NewsParser parser = new NewsParser();

                List<NewsItem> list = await Task.Run(() => parser.ParseFeed(responseString));
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
    }
}
