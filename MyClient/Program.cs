﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioUno;

namespace MyClient
{
    internal class Program
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
