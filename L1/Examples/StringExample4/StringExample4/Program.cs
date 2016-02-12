using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello";
            string nullStr = null;
            string emptyStr = String.Empty;

            string tempStr = str + nullStr;
            Console.WriteLine(tempStr);

            bool b = (emptyStr == nullStr);
            Console.WriteLine(b);

            string newStr = emptyStr + nullStr;

            Console.WriteLine(emptyStr.Length);
            Console.WriteLine(newStr.Length);

            string s1 = "\x0" + "abc";
            string s2 = "abc" + "\x0";

            Console.WriteLine("*" + s1 + "*");
            Console.WriteLine("*" + s2 + "*");

            Console.WriteLine(s2.Length);

            Console.ReadKey();
        }
    }
}
