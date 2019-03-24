using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_Programming
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            // Create, compile and run a “Introduction to Programming” console application.
            // Create a console application to print your name, email, age and gender.
            // Print the numbers 0, 178, -21 and 12 ^ 20 on the console.
            // Print sin(pi), cos(0), tan(pi / 2)
            // Write a program to read your first and last names and print them on the console, separated by space.
            
            string name;
            string email;

            char gender;

            int age;

            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter email:");
            email = Console.ReadLine();

            Console.WriteLine("Enter gender [m/f]:");
            gender = Console.ReadLine().First();

            Console.WriteLine("Enter age:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("{0}\nemail: {1}\ngender: {2}\nage: {3}", name, email, gender, age);
            Console.WriteLine();

            Console.WriteLine("{0}, {1}, {2}, {3}", 0, 178, -21, Math.Pow(12, 20));

            Console.WriteLine("{0}\n{1}\n{2}", Math.Sin(Math.PI), Math.Cos(0), Math.Tan(Math.PI / 2));

        }
    }
}
