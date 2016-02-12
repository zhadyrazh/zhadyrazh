using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample2
{
    public struct CoOrds
    {
        public int x, y;

        public CoOrds(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }

    // Declare a struct object without new.
    class TestCoOrdsNoNew
    {
        static void Main(string[] args)
        {
            // Declare an object
            CoOrds coords1;

            // Initialize:
            coords1.x = 10;
            coords1.y = 20;

            // Display results:
            Console.Write("CoOrds 1:");
            Console.WriteLine(" x = {0}, y = {1}", coords1.x, coords1.y);

            // Keep the console window open in debug mode
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
