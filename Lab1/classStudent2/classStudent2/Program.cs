using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classStudent2
{
    class Student
    {
        // fields
        public string Name;
        public string Faculty;
        public string ID;
        int Year;
        

        // constructor
        public Student(string Name, string Faculty, string ID, int Year)
        {
            this.Name = Name;
            this.Faculty = Faculty;
            this.ID = ID;
            this.Year = Year;
            
         
        }

        // метод ToString()
        public override string ToString()
        {
            return Name + " " + Faculty + " " + ID + " " + Year;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            string Faculty = Console.ReadLine();
            string ID = Console.ReadLine();

            // метод Parse()
            int Year = int.Parse(Console.ReadLine());
                  

            Student st = new Student(Name, Faculty, ID, Year);
            Console.WriteLine(st);

            Console.ReadKey();
        }
    }
}
