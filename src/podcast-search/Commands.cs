using System;
using System.Collections.Generic;

using CLAP;

using podcast_search.Extensions;
using podcast_search.Parsers;

namespace podcast_search
{
    public class Commands
    {
        [Verb(IsDefault = true, Aliases = "fetch,f", Description = "Fetch the web page to search for podcasts")]
        public void FetchCommand(Uri uri)
        {
            string html = uri.GetWebPage();
            var parser = new ItunesParser();
            IEnumerable<Podcast> podcasts = parser.Parse(html);
        }
    }
}