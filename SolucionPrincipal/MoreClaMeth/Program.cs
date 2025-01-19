using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreClaMeth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro miCarro = new Carro();
            Carro.miMetodo();

            /*
            miCarro.Hacer = "Modelo viejo";
            miCarro.Modelo = "Algo jevi";
            miCarro.año = 2006;
            miCarro.color = "Azul";
            */
            Carro miOtroCarro;
            miOtroCarro = miCarro;

            Console.WriteLine("{0} {1} {2} {3} ", miOtroCarro.Hacer,
                miOtroCarro.Modelo, 
                miOtroCarro.año,
                miOtroCarro.color);

            miOtroCarro.Modelo = "98";
            /*
            Console.WriteLine("{0} {1} {2} {3} ", miCarro.Hacer,
                miCarro.Modelo,
                miCarro.año,
                miCarro.color);
            */
            Console.ReadLine();


        }
        class Carro
        {
            public string Hacer { get; set; }
            public string Modelo { get; set; }
            public int año { get; set; }
            public string color { get; set; }

            /*public Carro()
            {
                Hacer = "Nissan";
            }

            public Carro(string hacer, string modelo, int año, string color)
            {
                Hacer = hacer;
                Modelo = modelo;
                this.año = año;
                this.color = color;
            }*/

            public static void miMetodo()
            {
                Console.WriteLine("Esto hace algo");
               // Console.WriteLine(Make);
            }
        }
    }
}

