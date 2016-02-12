using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    class FormatString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();

            int j;
            Int32.TryParse(input, out j);

            string s;
            for(int i = 0; i < 10; i++)
            {
                s = String.Format("{0} times {1} = {2}", i,j, (i*j));
                Console.WriteLine(s);
            }

            Console.ReadKey();


        }
    }
}
