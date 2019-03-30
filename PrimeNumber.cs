using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Introduction_to_Programming
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("Check if number is prime:");
            int x = int.Parse(Console.ReadLine());

            bool notPrime = false;

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    notPrime = true;
                    break;
                }
            }

            if (notPrime)
            {
                Console.WriteLine("Number is NOT prime!");
            }
            else
            {
                Console.WriteLine("Number is prime.");
            }
        }
    }
}
