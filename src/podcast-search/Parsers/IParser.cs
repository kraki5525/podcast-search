using System.Collections.Generic;

namespace podcast_search.Parsers
{
    public interface IParser
    {
        IEnumerable<Podcast> Parse(string html);
    }
}