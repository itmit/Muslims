using System;
using System.Collections.Generic;
using System.Net;

using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Muslims.Models.Parser
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
				var feed = new NewsItem
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
							   ?.Value,
					Content = WebUtility.HtmlDecode(Regex.Replace(item.Element(nsContent + "encoded")
																	  ?.Value ??
																  throw new InvalidOperationException(),
																  "<[^>]+>",
																  string.Empty)),
					Image = Regex.Match(item.Element(nsContent + "encoded")
											?.Value ??
										throw new InvalidOperationException(),
										"<img.+?src=[\"'](.+?)[\"'].*?>",
										RegexOptions.IgnoreCase)
								 .Groups[1]
								 .Value
				};

				feeds.Add(feed);
			}

			return feeds;
		}
		#endregion
	}
}
