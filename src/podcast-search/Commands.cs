using CLAP;

namespace podcast_search
{
    public class Commands
    {
        [Verb(IsDefault = true, Aliases = "fetch,f", Description = "Fetch the web page to search for podcasts")] 
        public void FetchCommand(string uri)
        {
            
        }
    }
}