using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModAcces
{
    internal class Program
    {
        private static string k = "";
        static void Main(string[] args)
        {
            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine(l);
            }

            //Console.WriteLine(i);
            Console.WriteLine("Fuera del for: " + j);
            Console.WriteLine(" k fuera del for: " + j);
            Console.ReadLine();

            Ayuda();
            Carro miCarro = new Carro();
            miCarro.HaceAlgo();
        }

        static void Ayuda()
        {
            Console.WriteLine("Valor de k dentro de ayuda(): " + k);
        }
    }
    class Carro
    {
        public void HaceAlgo()
        {
            Console.WriteLine(Ayuda());
        }
        
        private string Ayuda() 
        {
            return "Hola, pan con queso";
        }
    }
}
