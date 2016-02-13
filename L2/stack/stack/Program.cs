using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace stack
{
    class Program
    {
        static void RStack(string path)
        {
            // Stack
            Stack<string> dirs = new Stack<string>();
            dirs.Push(path);

            while (dirs.Count > 0)
            {
                string currentDir = dirs.Pop();
                string[] subdirs = Directory.GetDirectories(currentDir);
                string[] files = Directory.GetFiles(currentDir);

                Console.WriteLine(currentDir);

                foreach (string file in files)
                {
                    Console.WriteLine(file);

                }

                foreach (string str in subdirs)
                {
                    dirs.Push(str);
                }

            }
        }

        static void Main(string[] args)
        {
            RStack(@"C:\PT\zhadyrazh");
            Console.ReadKey();
        }
    }
}
