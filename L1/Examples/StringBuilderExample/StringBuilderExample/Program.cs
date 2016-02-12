using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder("Rat: the ideal pet");

            sb[0] = 'C';
            Console.WriteLine(sb.ToString());

            Console.ReadKey();

        }
    }
}
