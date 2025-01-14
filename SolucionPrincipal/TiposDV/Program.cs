using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposDV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  int X;
              int Y;

              X = 7;
              Y = X + 5;

              Console.WriteLine(Y);*/
              


            Console.WriteLine("Dime tu nombre");
            Console.Write("Dime tu primer nombre:");
            string primerNombre;
            primerNombre = Console.ReadLine();

            string apellido;
            Console.Write("Dime tu apellido:");
            apellido = Console.ReadLine();

            Console.WriteLine("¡Hey! Mucho gusto " + primerNombre + " " + apellido);
            Console.ReadLine();
        }
    }
}
