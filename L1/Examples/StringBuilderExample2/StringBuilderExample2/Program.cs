using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            // Create a string composed of numbers 0-9
            for(int i = 0; i < 10; i++)
            {
                sb.Append(i.ToString());
            }

            Console.WriteLine(sb);

            sb[0] = sb[9];
            Console.WriteLine(sb);

            Console.ReadKey();

           
                  

        }
    }
}
