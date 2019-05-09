using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Muslims.Models.Parser
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
			var parseFeed = new List<NewsItem>();
			foreach (var item in doc.Descendants("item"))
			{
				var newsItem = new NewsItem
				{
					Title = item.Element("title")
								?.Value,
					Link = item.Element("link")
							   ?.Value,
					Description = Regex.Replace(WebUtility.HtmlDecode(item.Element("description")
																		  ?.Value) ??
												throw new InvalidOperationException(),
												"<[^>]+>",
												string.Empty),
					Pubdate = item.Element("pubDate")
								  ?.Value,
					Guid = item.Element("guid")
							   ?.Value
				};
				parseFeed.Add(newsItem);
			}

			return parseFeed;
		}
		#endregion
	}
}
