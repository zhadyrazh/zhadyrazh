using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s3 = "Visual C# Express";

            Console.WriteLine(s3.Substring(7, 2));

            Console.WriteLine(s3.Replace("C#", "Basic"));

            int Index = s3.IndexOf("C");

            string s5 = "Printing Backwards";
            for(int i = 0; i < s5.Length; i++)
            {
                Console.WriteLine(s5[s5.Length-i-1]);
            }

            Console.ReadKey();
        }
    }
}
