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
            //    //first part
            //    Console.WriteLine("Bienvenido a las casa de Juan ¡El magnifico!");
            //    Console.WriteLine("Elije una puerta a tomar");
            //    string valorUsuario = Console.ReadLine();

            //    string mensaje = ""; 

            //    if (valorUsuario == "1") mensaje = "Mala elección, ahora me debes todo tu dinero";

            //    //Agregando más opciones

            //    else if (valorUsuario == "2") mensaje = "Mala elección, ahora tu casa es mía";

            //    else if (valorUsuario == "3") mensaje = "Buena elección ¡Te puedes ir de mi casa!";

            //    else
            //    {
            //        mensaje = "Entra por una puerta correcta, por favor";
            //        mensaje += ". Si no tomas un apuerta no podras entrar y ver mi hermosa casa";
            //    }

            //    Console.WriteLine(mensaje);
            //    Console.ReadLine();

            Console.WriteLine("Bienvenido a las casa de Juan ¡El magnifico!");
            Console.WriteLine("Elije una puerta a tomar");
            string valorUsuario = Console.ReadLine();

            string mensaje = (valorUsuario == "1") ? "bote" : "Selecciona una opción correcta";

            //Console.Write("Ganaste un ");
            //Console.Write(mensaje);
            //Console.Write(".");

            Console.WriteLine("Elejiste la puerta {0}, por eso, Ganaste un {0}.",valorUsuario, mensaje);
            Console.ReadLine();
        }



    }
}
