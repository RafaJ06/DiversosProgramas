using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                /*  Console.WriteLine(i);*/

                if (i == 7)
                    
                {
                    Console.WriteLine("se encontró el 7");
                    break;
                }
            }
            for (int miNumero = 0; miNumero < 12; miNumero++)
            {
                Console.WriteLine(miNumero);
            }
            Console.ReadLine();

            //Simple depuración de códigos vimos aquí
        }
    }
}
