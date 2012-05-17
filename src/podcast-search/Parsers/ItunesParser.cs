using System.Collections.Generic;
using System.Linq;

using HtmlAgilityPack;

namespace podcast_search.Parsers
{
    public class ItunesParser
    {
        public IEnumerable<Podcast> Parse(string html)
        {
            if (html.Length == 0)
            {
                return Enumerable.Empty<Podcast>();
            }

            var doc = new HtmlDocument();

            doc.LoadHtml(html);
            var nodes = doc.DocumentNode.SelectNodes("//div[@id=\"selectedcontent\"]/div/ul/li/a");

            if (nodes == null)
            {
                return Enumerable.Empty<Podcast>();
            }

            var podcasts = nodes.Elements().Select(node => new Podcast(node.Attributes["href"].Value, node.InnerText));

            return Enumerable.Empty<Podcast>();
        }
    }
}