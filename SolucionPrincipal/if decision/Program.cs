using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_decision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //first part
            Console.WriteLine("Bienvenido a las casa de Juan ¡El magnifico!");
            Console.WriteLine("Elije una puerta a tomar");
            string valorUsuario = Console.ReadLine();

            if (valorUsuario == "1")
            {

                string mensaje = "Mala elección, ahora me debes todo tu dinero";
                Console.WriteLine(mensaje);
            }

            //Agregando más opciones

            else if (valorUsuario == "2")
            {

                string mensaje = "Mala elección, ahora tu casa es mía";
                Console.WriteLine(mensaje);
            }

            else if (valorUsuario == "3")
            {

                string mensaje = "Buena elección ¡Te puedes ir de mi casa!";
                Console.WriteLine(mensaje);
            }

            else
            {
                Console.WriteLine("Entra por una puerta correcta, por favor");
            }

            Console.ReadLine();
        }

       
    }
}
