﻿using System.Net;

namespace BiblioUno
{
    //WebClient está obsoleto, supongo que por eso me da error.
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
           return GetWebpage(url);
        }

        public string ScrapeWebpage(string url, string filepath)
        {
          string reply = GetWebpage(url);
         

            File.WriteAllText(filepath, reply);
            return reply;
        }

        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }

    }
}
