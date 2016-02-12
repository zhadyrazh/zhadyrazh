﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classmembers
{
    public class Person
    {
        // Field
        public string name;

        // Constructor that takes no arguments
        public Person()
        {
            name = "unknown";
        }
       
        // Constructor that takes one argument
        public Person(string nm)
        {
            name = nm;
        }

        // Method
        public void SetName(string NewName)
        {
            name = NewName;
        }
    }

    class TestPerson
    {
        static void Main(string[] args)
        {
            // Call the constructor that has no parameters
            Person person1 = new Person();
            Console.WriteLine(person1.name);

            person1.SetName("John Smith");
            Console.WriteLine(person1.name);

            // Call the constructor that has one parameter
            Person person2 = new Person("Sarah Jones");
            Console.WriteLine(person2.name);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
