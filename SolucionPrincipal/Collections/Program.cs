using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Carro miCarro = new Carro();

                miCarro.Hacer = "Modelo viejo";
                miCarro.Modelo = "Algo jevi";
                miCarro.año = 2006;
                miCarro.color = "Azul";
                miCarro.VIN = "No";

                Carro miCarro2 = new Carro();

                miCarro.Hacer = "Geo";
                miCarro2.Modelo = "Prime";
                miCarro.VIN = "Si";

                Libro libro1 = new Libro();
                libro1.Autor = "Margarita";
                libro1.Titulo = "Leonel y yo";
                libro1.ISBN = "No sé qué es eso";

                //ArrayList are dynamically sized,
                //cool features sorting, remove items
                /*
                                ArrayList myLista = new ArrayList();
                                myLista.Add(libro1);
                                myLista.Add(miCarro2);
                                myLista.Add(miCarro);
                                myLista.Remove(libro1);

                                foreach (Carro carro in myLista)
                                {
                                        Console.WriteLine(carro.Hacer);
                                }

                                List<Carro> myLista = new List<Carro>();
                               // myLista.Add(libro1);
                                myLista.Add(miCarro2);
                                myLista.Add(miCarro);

                                foreach (Carro carro in myLista)
                                {
                                    Console.WriteLine(carro.Modelo);
                                }                
                                */

                /* Dictionary<string, Carro> miDiccionario = new Dictionary<string, Carro>();

                 miDiccionario.Add(miCarro.VIN, miCarro);
                 miDiccionario.Add(miCarro2.VIN, miCarro2);

                 Console.WriteLine(miDiccionario["Libro1"].Hacer);

                 */

               // string[] nombres = {"jose", "peter"};
               /*
                Carro carro = new Carro()
                { Hacer = "BMW", Modelo = "1890", VIN = "C4"};

                Carro carro2 = new Carro()
                { Hacer = "Mercedes", Modelo = "1990", VIN = "C5" };
                */

                List<Carro> list = new List<Carro>();
                {
                    new Carro { Hacer = "Mercedes", Modelo = "1990", VIN = "C5" };
                    new Carro { Hacer = "Toyota", Modelo = "1790", VIN = "C6" };
                }

                Console.ReadLine();


            }
        }
        class Libro
        {
            public string Titulo {  get; set; }
            public string ISBN { get; set; }
            public string Autor {  get; set; }
        }
        class Carro
        {
            public string VIN { get; set; }
            public string Hacer { get; set; }
            public string Modelo { get; set; }
            public int año { get; set; }
            public string color { get; set; }

        }
    }
}
