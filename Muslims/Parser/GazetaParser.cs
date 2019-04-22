using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using Muslims.Models;
using System.Text.RegularExpressions;

namespace Muslims.Parser
{
    public class GazetaParser
    {

        public GazetaParser()
        {
        }

        public List<NewsItem> ParseFeed(string response)
        {
            if (response == null)
            {
                return null;
            }



            XDocument doc = XDocument.Parse(response);
            List<NewsItem> gazetafeeds = new List<NewsItem>();
            foreach (var item in doc.Descendants("item"))
            {
                NewsItem gazetafeed = new NewsItem();
                gazetafeed.Title = item.Element("title").Value.ToString();
                gazetafeed.Link = item.Element("link").Value.ToString();
                gazetafeed.Description = Regex.Replace(System.Net.WebUtility.HtmlDecode(item.Element("description").Value.ToString()), "<[^>]+>", string.Empty);
                gazetafeed.Pubdate = item.Element("pubDate").Value.ToString();
                gazetafeed.Guid = item.Element("guid").Value.ToString();
                gazetafeeds.Add(gazetafeed);
            }
            return gazetafeeds;
        }
    }
}
