using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream FSOne = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream FSSecond = new FileStream("output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            StreamWriter Write = new StreamWriter(FSSecond);
            StreamReader Read = new StreamReader(FSOne);

            string[] Collection = Read.ReadLine().Split();

            int max = Convert.ToInt32(Collection[0]);
            int min = Convert.ToInt32(Collection[0]);

            foreach(string Runner in Collection)
            {
                if (Convert.ToInt32(Runner) < min)
                    min = Convert.ToInt32(Runner);
                if (Convert.ToInt32(Runner) > max)
                    max = Convert.ToInt32(Runner);
            }

            Console.WriteLine("Max is {0}", max);
            Console.WriteLine("Min is {0}", min);

            Write.WriteLine("max is {0}", max);
            Write.WriteLine("min is {0}", min);

            Write.Close();
            Read.Close();

            Console.ReadKey();
          
        }
    }
}
