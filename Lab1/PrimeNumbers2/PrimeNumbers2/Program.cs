﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(); // Split()

            for(int i = 0; i < s.Length; i++)
            {
                int is_prime = int.Parse(s[i]); // Parse()
                int sum = 0;

                for(int j = 2; j < is_prime; j++)
                {
                    if (is_prime % j == 0)
                        sum++;
                }
                if (sum < 1)
                    Console.WriteLine(is_prime);

                Console.ReadKey();


            }
        }
    }
}
