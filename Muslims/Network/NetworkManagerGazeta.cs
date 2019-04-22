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
    public sealed class NetworkManagerGazeta
    {
        public static NetworkManagerGazeta network_manager_gazeta = new NetworkManagerGazeta();
        public static string network_url = "http://dum-spb.ru/category/gazeta/feed";

        private NetworkManagerGazeta()
        {
        }

        public static NetworkManagerGazeta Instance
        {
            get
            {
                return network_manager_gazeta;
            }
        }

        public async Task<List<NewsItem>> GetSyncFeedAsync()
        {
            if (this.IsConnected())
            {
                Uri uri = new Uri(network_url);
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(uri);
                String response_string = await response.Content.ReadAsStringAsync();
                GazetaParser parser = new GazetaParser();
                // List<FeedItem> list = await Task.Run(() => parser.ParseFeed(response_string));
                List<NewsItem> gazetalist = await Task.Run(() => parser.ParseFeed(response_string));
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
    }
}
