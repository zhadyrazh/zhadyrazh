using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            string question = "hOW DOES mICROSOFT wORD DEAL WITH THE cAPS lOCK KEY?";

            System.Text.StringBuilder sb = new System.Text.StringBuilder(question);

            for(int j = 0; j < sb.Length; j++)
            {
                if (Char.IsLower(sb[j]) == true)
                    sb[j] = Char.ToUpper(sb[j]);
                else if (Char.IsUpper(sb[j]) == true)
                    sb[j] = Char.ToLower(sb[j]);
            }

            string corrected = sb.ToString();
            Console.WriteLine(corrected);

            Console.ReadKey();

        }
    }
}
