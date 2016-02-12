using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class TestArrayClass
    {
        static void Main()
        {
            // Declare and initialize array:
            int[,] theArray = new int[5, 10];

            Console.WriteLine("The array has {0} dimensions.", theArray.Rank);
            Console.ReadKey();

        }
    }
}
