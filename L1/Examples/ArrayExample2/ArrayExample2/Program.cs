using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };

            foreach(int i in numbers)
            {
                Console.Write("{0}", i);
                Console.WriteLine();
            }

            Console.WriteLine();

            int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };

            foreach(int i in numbers2D)
            {
                Console.Write("{0}", i);
                Console.WriteLine();
            }
           
            Console.ReadKey();  
        }
    }
}
