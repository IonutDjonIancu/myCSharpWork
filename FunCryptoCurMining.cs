using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Write an expression that checks if given integer is odd or even.
// Write a boolean expression that checks if an integer can be divided by 2, 3 and 4 (all three  numbers at the same time) without remainder(use logical operators).
// Write an expression to check if the 3rd digit of an integer is 3. e.g. 5352 -> true
// Write an expression that checks if a given point(x, y) is within a circle with radius 4 and  centre at(0,0)
// Write an expression that checks if a given positive integer n<=100 is prime.
// Write an if statement that exchanges the values of 2 numbers if the first is bigger than the  second
// Write a program that finds the biggest of 3 integers, using if statements.
// Sort 3 integer numbers in an ascending order, using if statements.
// Write a program that lets the user enter a number between 10 and 19 and prints on the console  the name of the number.Use switch.
// We are given 5 integer numbers. Write a program that checks if there is a subset of these 5 numbers which sums to zero.List all such sums.

namespace Introduction_to_Programming
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            Random random = new Random();
            ulong counter = 0;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                arr[0] = random.Next(1, 10);
                arr[1] = random.Next(1, 10);
                arr[2] = random.Next(1, 10);
                counter++;

                Console.WriteLine("[{0}][{1}][{2}]", arr[0], arr[1], arr[2]);
                if ( (arr[0] == arr[1]) && (arr[0] == arr[2]) )
                {
                    Console.ResetColor();
                    Console.WriteLine("{0} tries", counter);
                    break;
                }
                Thread.Sleep(50);
            }
        }
    }
}
