using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace minPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream FileStreamRead = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream FileStreamWrite = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            StreamWriter Writer = new StreamWriter(FileStreamWrite);
            StreamReader Reader = new StreamReader(FileStreamRead);

            string[] Numbers = Reader.ReadLine().Split();
            int MinPrimeNumber = Convert.ToInt32(Numbers[0]);

            foreach(string Runner in Numbers)
            {
                int Counter = 0;
                bool is_prime = false;
                int prime = Convert.ToInt32(Runner);

                for(int i = 1; i < prime; i++ )
                {
                    if(prime % i == 0)
                    {
                        Counter++;
                    }
                    if (Counter < 2)
                    {
                        is_prime = true;
                    }

                    if(is_prime)
                    {
                        if (is_prime)
                            if (MinPrimeNumber > prime)
                                MinPrimeNumber = prime;
                    }
                   
                    Writer.WriteLine(MinPrimeNumber);

                    Console.ReadKey();
                    Writer.Close();
                    Reader.Close();
                }
            }


         
        }
    }
}
