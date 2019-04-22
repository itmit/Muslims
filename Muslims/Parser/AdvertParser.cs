using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using Muslims.Models;
using System.Text.RegularExpressions;

namespace Muslims.Parser
{
    public class AdvertParser
    {

        public AdvertParser()
        {
        }

        public List<NewsItem> ParseFeed(string response)
        {
            if (response == null)
            {
                return null;
            }



            XDocument doc = XDocument.Parse(response);
            List<NewsItem> advertfeeds = new List<NewsItem>();
            foreach (var item in doc.Descendants("item"))
            {
                NewsItem advertfeed = new NewsItem();
                advertfeed.Title = item.Element("title").Value.ToString();
                advertfeed.Link = item.Element("link").Value.ToString();
                advertfeed.Description = Regex.Replace(System.Net.WebUtility.HtmlDecode(item.Element("description").Value.ToString()), "<[^>]+>", string.Empty);
                advertfeed.Pubdate = item.Element("pubDate").Value.ToString();
                advertfeed.Guid = item.Element("guid").Value.ToString();
                advertfeeds.Add(advertfeed);
            }
            return advertfeeds;
        }
    }
}
