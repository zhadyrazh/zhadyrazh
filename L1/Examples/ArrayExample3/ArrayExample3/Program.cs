using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample3
{
    class ArrayClass
    {
        static void PrintArray(string[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "{0}", i < arr.Length - 1 ? " " : " ");
            }
            Console.WriteLine();
         }

        static void ChangeArray(string[] arr)
        {
            arr = (arr.Reverse()).ToArray();
            Console.WriteLine("arr[0] is {0} in ChangeArray.", arr[0]);
        }

        static void ChangeArrayElements(string[] arr)
        {
            arr[0] = "Sat";
            arr[1] = "Fri";
            arr[2] = "Thu";
            Console.WriteLine("arr[0] is {0} in ChangeArrayElements.", arr[0]); 
        }

        static void Main(string[] args)
        {
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            PrintArray(weekDays);

            ChangeArray(weekDays);

            Console.WriteLine("Array weekDays after the call to ChangeArray:");
            PrintArray(weekDays);
            Console.WriteLine();

            ChangeArrayElements(weekDays);

            Console.WriteLine("Array weekDays after the call to ChangeArrayElements:");
            PrintArray(weekDays);

            Console.ReadKey();

        }
    }
}
