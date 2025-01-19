using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace LastLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer miTiempo = new System.Timers.Timer(2000);
            miTiempo.Elapsed += MiTiempo_Elapsed;
            miTiempo.Elapsed += MiTiempo_Elapsed1;

            miTiempo.Start();

            Console.WriteLine("Presiona para quitar el verde");
            Console.ReadLine();

            miTiempo.Elapsed -= MiTiempo_Elapsed1;

            Console.ReadLine();
        }
        private static void MiTiempo_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Elapsed1: {0:HH:mm:ss.fff}", e.SignalTime);
        }
        private static void MiTiempo_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Elapsed1: {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
