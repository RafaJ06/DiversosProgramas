using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[] numbers = new int[5];
             numbers[0] = 1;
             numbers[1] = 2;
             numbers[2] = 3;
             numbers[3] = 4;
             numbers[4] = 5;

             Console.WriteLine(numbers.Length);
           */

             int[] numbers = new int[] { 1, 2, 3, 4, 5, };
            /*
             for (int i = 0; i < numbers.Length; i++)
             {
                 Console.WriteLine(numbers[i]);
             }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }*/


            string voltear = "Una oración muy larga " + 
                ".Otra oración larga.";

            char[] charArray = voltear.ToCharArray();
            Array.Reverse(charArray);

            foreach (char voltearCaracter in charArray)
            {

                Console.Write(voltearCaracter);
            }

            Console.ReadLine();
        }
    }
}
