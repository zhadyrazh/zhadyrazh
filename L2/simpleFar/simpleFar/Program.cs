using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace simpleFar
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:/");   // DirectoryInfo

            int index = 0;
            FileInfo[] files = dir.GetFiles();              // FileInfo

            while(true)
            {
                for(int i = 0; i < files.Length; i++)
                {
                    if(index == i)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine(files[i].Name);
                }


                ConsoleKeyInfo button = Console.ReadKey();
                if(button.Key == ConsoleKey.UpArrow)           // UpArrow
                {
                    if(index > 0)
                        index--;
                }
                if(button.Key == ConsoleKey.DownArrow)         // DownArrow
                {
                    if (index < files.Length - 1)
                        index++;
                }
                if (button.Key == ConsoleKey.Escape)           // Escape
                    break;

                Console.Clear();
         

            }
            Console.ReadKey();


        }
    }
}
