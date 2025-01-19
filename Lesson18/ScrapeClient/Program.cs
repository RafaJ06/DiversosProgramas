using System;
using ScrapeLibrary;

namespace ScrapeClient
{
    class Program
    {
        static void Main(string[] args)
        {

            Scrape myScrape = new Scrape();
            string value = myScrape.ScrapeWebpage("http://msdn.microfsoft.com");

            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
