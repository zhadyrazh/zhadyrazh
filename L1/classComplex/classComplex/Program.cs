using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classComplex
{
    class Complex
    {
        // fields
        public int a, b;

        // Constructor
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        // перегрузка оператора +
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c3 = new Complex(c1.a + c2.a, c1.b + c2.b);
            return c3;
        }

        // метод ToString()
        public override string ToString()
        {
            return a + "/" + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex m = new Complex(13, 38);
            Complex n = new Complex(12, 11);
            Complex s = m + n;

            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
