using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro miCarro = new Carro();
            miCarro.Hacer = "Mi mamá me mima";
            miCarro.Modelo = "Un modelo x";
            miCarro.año = 2006;
            miCarro.color = "Azul";

            Console.WriteLine("{0} {1} {2} {3}",
                miCarro.Hacer, miCarro.Modelo, miCarro.año, miCarro.color);

            //decimal valor = valorCarro(miCarro);
            //Console.WriteLine("{0:C}", valor);

            Console.WriteLine("{0:C}", miCarro.ValorMercado());

            Console.ReadLine();
        }
        private static decimal valorCarro(Carro carro)
        {
            decimal result = 100.0M;
            return result;
        }
    }
    class Carro
    {
        public string Hacer { get; set; }
        public string Modelo { get; set; }
        public int año { get; set; }
        public string color { get; set; }

       public decimal ValorMercado()
        {
            decimal carroValor;
            if (año > 1990) carroValor = 1000;
            else carroValor = 2000;

            return carroValor;
            
                
            
        }
    }
}
