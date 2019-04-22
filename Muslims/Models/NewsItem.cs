using System;
namespace Muslims.Models
{
    public class NewsItem
    {

        public string Title { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string Pubdate { get; set; }
        public string Guid { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }

        public NewsItem()
        {
        }
    }
}
