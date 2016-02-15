using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            DirectoryInfo dir = new DirectoryInfo(path);
            Search(dir);
        }

        static void Search(DirectoryInfo dir)
        {
            // GetFiles() -- получает список файлов
            int cnt = dir.GetFiles().Length;

            Console.WriteLine(cnt + " files are located in " + dir.FullName);
            foreach (DirectoryInfo ndir in dir.GetDirectories())
            {
                Search(ndir);
            }
            Console.ReadKey();

        }
    }
}
