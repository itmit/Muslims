using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Muslims.Models;

namespace Muslims.Parser
{
	public class GazetaParser
	{
		#region Public
		public List<NewsItem> ParseFeed(string response)
		{
			if (response == null)
			{
				return null;
			}

			var doc = XDocument.Parse(response);
			var gazetafeeds = new List<NewsItem>();
			foreach (var item in doc.Descendants("item"))
			{
				var gazetafeed = new NewsItem();
				gazetafeed.Title = item.Element("title")
									   .Value;
				gazetafeed.Link = item.Element("link")
									  .Value;
				gazetafeed.Description = Regex.Replace(WebUtility.HtmlDecode(item.Element("description")
																				 .Value),
													   "<[^>]+>",
													   string.Empty);
				gazetafeed.Pubdate = item.Element("pubDate")
										 .Value;
				gazetafeed.Guid = item.Element("guid")
									  .Value;
				gazetafeeds.Add(gazetafeed);
			}

			return gazetafeeds;
		}
		#endregion
	}
}
