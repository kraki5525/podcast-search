using System;
using System.IO;
using System.Net;

namespace podcast_search
{
    public class WebClient
    {
        public virtual string GetWebPage(Uri uri)
        {
            var request = (HttpWebRequest)HttpWebRequest.Create(uri);
            var html = "";

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception("");
                }

                using (var stream = response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                }
            }

            return html;
        }
    }
}