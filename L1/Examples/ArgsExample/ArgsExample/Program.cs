using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgsExample
{
    class ForEachTest
    {
        static void Main(string[] args)
        {
            int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach(int element in fibarray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            for(int i = 0; i < fibarray.Length; i++)
            {
                Console.WriteLine(fibarray[i]);
            }
            Console.WriteLine();

            int count = 0;
            foreach(int element in fibarray)
            {
                count += 1;
                Console.WriteLine("Element #{0}: {1}", count, element);
            }

            Console.WriteLine("Number of the elements in the array: {0}", count);

            Console.ReadKey();




        }
    }
}
