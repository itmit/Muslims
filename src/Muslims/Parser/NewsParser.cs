using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using Muslims.Models;
using System.Text;
using System.Text.RegularExpressions;

namespace Muslims.Parser
{
    public class NewsParser
    {

        public NewsParser()
        {
        }

        public List<NewsItem> ParseFeed(string response)
        {
            if (response == null)
            {
                return null;
            }


            XNamespace nsContent = "http://purl.org/rss/1.0/modules/content/";
            XDocument doc = XDocument.Parse(response);
            List<NewsItem> feeds = new List<NewsItem>();
            foreach (var item in doc.Descendants("item"))
            {
                NewsItem feed = new NewsItem();
                feed.Title = item.Element("title").Value.ToString();
                feed.Link = item.Element("link").Value.ToString();
                StringBuilder str = new StringBuilder(item.Element("description").Value);
                feed.Description = Regex.Replace(System.Net.WebUtility.HtmlDecode(item.Element("description").Value.ToString()), "<[^>]+>", string.Empty);
                feed.Pubdate = item.Element("pubDate").Value.ToString();
                feed.Guid = item.Element("guid").Value.ToString();
                feed.Content = System.Net.WebUtility.HtmlDecode(Regex.Replace(item.Element(nsContent + "encoded").Value.ToString(), "<[^>]+>", string.Empty));
                feed.Image = Regex.Match(item.Element(nsContent + "encoded").Value.ToString(), "<img.+?src=[\"'](.+?)[\"'].*?>", RegexOptions.IgnoreCase).Groups[1].Value;
                feeds.Add(feed);
            }
            return feeds;
        }
    }
}
