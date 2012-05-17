namespace podcast_search
{
    public class Podcast
    {
        public string Uri { get; set; }
        public string Description { get; set; }

        public Podcast(string uri, string description)
        {
            Uri = uri;
            Description = description;
        }
    }
}