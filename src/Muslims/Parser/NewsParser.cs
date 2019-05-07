using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Muslims.Models;

namespace Muslims.Parser
{
	public class NewsParser
	{
		#region Public
		public List<NewsItem> ParseFeed(string response)
		{
			if (response == null)
			{
				return null;
			}

			XNamespace nsContent = "http://purl.org/rss/1.0/modules/content/";
			var doc = XDocument.Parse(response);
			var feeds = new List<NewsItem>();
			foreach (var item in doc.Descendants("item"))
			{
				var feed = new NewsItem();
				feed.Title = item.Element("title")
								 ?.Value;
				feed.Link = item.Element("link")
								?.Value;

				var str = new StringBuilder(item.Element("description")
												?.Value);

				feed.Description = Regex.Replace(WebUtility.HtmlDecode(item.Element("description")
																		   ?.Value) ??
												 throw new InvalidOperationException(),
												 "<[^>]+>",
												 string.Empty);

				feed.Pubdate = item.Element("pubDate")
								   ?.Value;
				feed.Guid = item.Element("guid")
								?.Value;

				feed.Content = WebUtility.HtmlDecode(Regex.Replace(item.Element(nsContent + "encoded")
																	   ?.Value ??
																   throw new InvalidOperationException(),
																   "<[^>]+>",
																   string.Empty));

				feed.Image = Regex.Match(item.Element(nsContent + "encoded")
											 ?.Value ??
										 throw new InvalidOperationException(),
										 "<img.+?src=[\"'](.+?)[\"'].*?>",
										 RegexOptions.IgnoreCase)
								  .Groups[1]
								  .Value;

				feeds.Add(feed);
			}

			return feeds;
		}
		#endregion
	}
}
