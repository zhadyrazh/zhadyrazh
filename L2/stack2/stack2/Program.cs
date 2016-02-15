using System;
using System.IO;                  // System.IO
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace stack2
{
    class Program
    {
        static void UseStack(string path)                  // function UseStack with parameter path
        {
            Stack<string> dirs = new Stack<string>();        // Stack
            dirs.Push(path);                               // Push

            while(dirs.Count > 0)
            {
                string currentDir = dirs.Pop();          // Pop

                string[] subdirs = Directory.GetDirectories(currentDir);
                string[] files = Directory.GetFiles(currentDir);

                Console.WriteLine(currentDir);

                foreach(string file in files)
                {
                    Console.WriteLine(file);
                }

                foreach(string str in subdirs)
                {
                    dirs.Push(str);                             // Push
                }

            }


        }


        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            UseStack(path);                     // function UseStack
            Console.ReadKey();
        }
    }
}
