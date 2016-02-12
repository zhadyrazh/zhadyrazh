using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample4
{
    class ArrayClass2D
    {
        static void Print2DArray(int[,] arr)
        {
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("Element ({0}, {1} = {2})", i, j, arr[i, j]);
                }
            }
        }
        static void Main(string[] args)
        {
            Print2DArray(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, {7, 8 } });

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
