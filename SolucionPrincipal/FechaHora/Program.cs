using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechaHora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime myHora = DateTime.Now;
            // Console.WriteLine(myHora.ToString());
            // Console.WriteLine(myHora.ToShortDateString());
            // Console.WriteLine(myHora.ToShortTimeString());
            // Console.WriteLine(myHora.ToLongDateString());
            //Console.WriteLine(myHora.ToLongTimeString());

            // Console.WriteLine(myHora.AddDays(4).ToLongDateString());
            //  Console.WriteLine(myHora.AddHours(3).ToLongTimeString());
            //  Console.WriteLine(myHora.Month);
            // DateTime birthDay = new DateTime(2006, 2,6);

            DateTime birthDay = DateTime.Parse("12/2/2006");
            TimeSpan miEdad = DateTime.Now.Subtract(birthDay);
            Console.WriteLine(miEdad.TotalDays);

             Console.ReadLine();
        }
    }
}
