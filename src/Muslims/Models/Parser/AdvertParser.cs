using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Muslims.Models;

namespace Muslims.Parser
{
	public class AdvertParser
	{
		#region Public
		public List<NewsItem> ParseFeed(string response)
		{
			if (response == null)
			{
				return null;
			}

			var doc = XDocument.Parse(response);
			var advertfeeds = new List<NewsItem>();
			foreach (var item in doc.Descendants("item"))
			{
				var advertfeed = new NewsItem();
				advertfeed.Title = item.Element("title")
									   .Value;
				advertfeed.Link = item.Element("link")
									  .Value;
				advertfeed.Description = Regex.Replace(WebUtility.HtmlDecode(item.Element("description")
																				 .Value),
													   "<[^>]+>",
													   string.Empty);
				advertfeed.Pubdate = item.Element("pubDate")
										 .Value;
				advertfeed.Guid = item.Element("guid")
									  .Value;
				advertfeeds.Add(advertfeed);
			}

			return advertfeeds;
		}
		#endregion
	}
}
