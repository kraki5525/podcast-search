using System;
using System.IO;
using System.Net;

namespace podcast_search.Extensions
{
    public static class UriExtensions
    {
         public static string GetWebPage(this Uri uri)
         {
            var request = (HttpWebRequest) HttpWebRequest.Create(uri);
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