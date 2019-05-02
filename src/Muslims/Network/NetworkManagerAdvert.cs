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
    public sealed class NetworkManagerAdvert
    {
        public static NetworkManagerAdvert network_manager_advert = new NetworkManagerAdvert();
        public static string network_url = "http://dum-spb.ru/category/advert/feed";

        private NetworkManagerAdvert()
        {
        }

        public static NetworkManagerAdvert Instance
        {
            get
            {
                return network_manager_advert;
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
                AdvertParser parser = new AdvertParser();
                // List<FeedItem> list = await Task.Run(() => parser.ParseFeed(response_string));
                List<NewsItem> advertlist = await Task.Run(() => parser.ParseFeed(response_string));
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
    }
}
