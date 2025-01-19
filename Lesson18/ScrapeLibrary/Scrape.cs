using System.Net;

namespace ScrapeLibrary
{

    //Lo enseñado aquí está obsoleto. Ha de ser esa la razón de porque el programa no funciona.
    //Encontraré otras formas de hacer esto.
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
            string content  =
            client.DownloadString(url);
            content += "THAT´S ALL FOLKS!!!";
            return content;
        }

    }
}


