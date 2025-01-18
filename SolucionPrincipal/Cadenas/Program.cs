using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string myString = "";
            //string mystring = "Un texto con \"Comillas\"";
            //string myString = "Salto de \nlinea";
            //myString = "Go to your c:\\drive";
            //myString = @"GO to your c:\drive";

            //myString = String.Format("{1} = {0}", "Uno", "Dos");

            //myString = String.Format("{0:C}", 123.45);

            //myString = String.Format("{0:N}", 123456789);
            //myString = String.Format("Porcentaje: {0:P}", 123);
            //myString = String.Format("Número de telefono: {0:(###) ###-####}", 8298807282);

            //myString = "Epidemia de pies andantes  ";

            //myString = myString.Substring(0, 10);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", ".");
            //myString = myString.Remove(6, 10);
            //myString = String.Format("Tamaño antes {0} -- Tamaño después: {1}",
            //myString.Length, myString.Trim().Length);
            /*
            myString = "";

            for (int i = 0; i < 100; i++) 
            {
                myString += "--" + i.ToString();
            }*/
             
            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
       
    }
}
