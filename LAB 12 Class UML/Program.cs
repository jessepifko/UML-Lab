using System;
using System.Collections.Generic;

namespace LAB_12_Class_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> People = new List<string>();
            {
                Student a = new Student("Karen Wimbledon ", "26800 Novel Ave ", "GC Bootcamp ", 2020, 600.00);
                Console.WriteLine(a);

                Student b = new Student("Jeff Shmeffery ", "500 W 5th St ", "GC Bootcamp ", 2020, 600);
                Console.WriteLine(b);

                Student c = new Student("Mary Berry ", "200 N Elms St ", "GC Bootcamp ", 2020, 600);
                Console.WriteLine(c);

                Staff d = new Staff("Stephanie Lumpkins ", "22525 Warren Blvd ", "Central Michigan University ", 120000.00);
                Console.WriteLine(d);

                Staff e = new Staff("Winslow Mason ", "12 8th St ", "University of Michigan ", 100000.00);
            }

            Console.WriteLine(People);

        }
        public static void AddPerson()
        {
            
            string input = Console.ReadLine();
            
        }

        
    }
}
