using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefCrearMet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Juego del Nombre");

            Console.Write("Dime tu primer nombre ");
            string nombre = Console.ReadLine();

            Console.Write("Dime tu apellido ");
            string apellido = Console.ReadLine();

            Console.Write("Dime la ciudad en que naciste ");
            string ciudad = Console.ReadLine(); 

            char[] nombreLista = nombre.ToArray();
            Array.Reverse(nombreLista);

            char[] apellidoLista = apellido.ToArray();
            Array.Reverse(apellidoLista);

            char[] ciudadLista = ciudad.ToArray();
            Array.Reverse(ciudadLista);
            
                MostrarResultado(TextoReverso(nombre),
                TextoReverso(apellido), TextoReverso(ciudad))        

            Console.ReadLine();

        }
        private static string TextoReverso(string mensaje)
        {
            char[] mensajeLista = mensaje.ToArray();
            Array.Reverse(mensajeLista);

            return String.Concat(mensajeLista);
           
        }

        private static void MostrarResultado(string nombreReverso, 
            string apellidoReverso, string ciudadReverso)
        {
            Console.WriteLine("Resultados: ");
            Console.Write(String.Format("{0} {1} {2}", nombreReverso,
               apellidoReverso, ciudadReverso));
        }
        private static void MostrarResultado(string mensaje)
        {
            Console.WriteLine("Resultados: ");
            Console.Write(mensaje);
        }

    }
}
