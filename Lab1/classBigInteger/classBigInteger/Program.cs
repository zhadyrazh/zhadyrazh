using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classBigInteger
{
    class BigInteger
    {
        // fields
        public string str;
        public int amount;

        // array
        char[] resultant = new char[1000];

        // constructor
        public BigInteger(string str)
        {
            this.str = str;
            this.amount = str.Count(); // метод Count()
        }

        // ToString()
        public override string ToString()
        {
            if (str[0] != '0')
                return str;
            else
            {
                string str1 = str;
                for (int i = 1; i < amount; i++)
                {
                    str1 += str[i];
                }
                return str1;
            }
        }

        // ПЕРЕГРУЗКА ОПЕРАТОРА +
        public static BigInteger operator +(BigInteger first, BigInteger second)
        {
            int CountOfFirst = first.amount;
            int CountOfSecond = second.amount;
            int MaxCount = Math.Max(CountOfFirst, CountOfSecond); // Math.Max method
            char[] Result = new char[1000]; // array
            int memory = 0;

            for(int i = 0; i < MaxCount; i++)
            {
                if(CountOfFirst <= i)
                {
                    if(memory == 1)
                    {
                        Result[MaxCount - i] = (Convert.ToChar((memory + Convert.ToInt32(second.str[CountOfSecond - i - 1] - '0')) + '0'));
                        memory = 0;
                    }
                    else
                    {
                        Result[MaxCount - i] = second.str[CountOfSecond - i - 1];
                    }

                    continue;

                }
                if(CountOfSecond <= i)
                {
                    if(memory == 1)
                    {
                        Result[MaxCount - i] = (Convert.ToChar((memory + Convert.ToInt32(first.str[CountOfFirst - i - 1] - '0')) + '0'));
                        memory = 0;
                    }
                    else
                    {
                        Result[MaxCount - i] = first.str[CountOfFirst - i - 1];
                    }
                    continue;
                }
                if(memory + Convert.ToInt32(first.str[CountOfFirst - i - 1] - '0') + Convert.ToInt32(second.str[CountOfSecond - i - 1] - '0') >= 10)
                {
                    Result[MaxCount - i] = Convert.ToChar((memory + Convert.ToInt32(first.str[CountOfFirst - i - 1] - '0') + Convert.ToInt32(second.str[CountOfSecond - i - 1] - '0')) % 10);
                    memory = 1;
                    Result[MaxCount - i] = Convert.ToChar(Result[MaxCount - i] + '0');
                }
                else
                {
                    Result[MaxCount - i] = Convert.ToChar(memory + Convert.ToInt32(first.str[CountOfFirst - i - 1] - '0') + Convert.ToInt32(second.str[CountOfSecond - i - 1] - '0'));
                    memory = 0;
                    Result[MaxCount - i] = Convert.ToChar(Result[MaxCount - i] + '0');
                }
            }

            string Converting = " ";

            if (memory == 1)
            {
                Result[0] = '1';
            }

            else
                Result[0] = '0';

            for(int i = 0; i < MaxCount; i++)
            {
                Converting += Result[i];
            }

            BigInteger final = new BigInteger(Converting);
            return final;


        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two big numbers:");
            string FirstString = Console.ReadLine();
            string SecondString = Console.ReadLine();

            BigInteger FS = new BigInteger(FirstString);
            BigInteger SS = new BigInteger(SecondString);
            BigInteger result = FS + SS;

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
