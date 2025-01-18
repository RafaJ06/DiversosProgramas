using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//While Iteración
namespace WhileITE
{
     class Program
    {
        static void Main(string[] args) {

            bool mostrarMenu = true;
          
            while (mostrarMenu) {
                
                mostrarMenu =  MainMenu();
            }
        }

        private static bool MainMenu()
        {

            Console.WriteLine("Elije una opción");
            Console.WriteLine("1)  Mostrar Números");
            Console.WriteLine("2) Adivinanza");
            Console.WriteLine("3) Exit");

            string result = Console.ReadLine();

            if (result == "1")
            {

                MostrarNombres();
                return true;
            }
            else if (result == "2")
            {
                AdivinaJuego();
                return true;
            }

            else if (result == "3")
            {
                return false;
            }

            else  
            {
                return false;
            }

        }
        private static void MostrarNombres()
        {
            Console.WriteLine("¡Mostrar números!");
            Console.Write("Escribe un número: ");
            int resultado = int.Parse(Console.ReadLine());
            int contador = 1;
            while (resultado + 1 > contador)
            {
                Console.Write(contador);
                Console.Write("-");
                contador++;
            }
            Console.ReadLine();
        }

        private static void AdivinaJuego()
        {
            Console.Clear();
            Console.WriteLine("Número adivinado");

            Random myRandom = new Random();
            int aleatorio = myRandom.Next(1, 11);

            int adivinanzas = 0;
            bool mal = true;

            do
            {
                Console.WriteLine("Adivina un número entre 1 y 10");
                string resultado = Console.ReadLine();
                adivinanzas++;
                if (resultado == aleatorio.ToString())
                    mal = false;
                else
                    Console.WriteLine("Fallaste");
            } while (mal);
                Console.WriteLine("Correcto, te tomó {0} intentos.", adivinanzas);


            Console.ReadLine();
        }
    }
    }



