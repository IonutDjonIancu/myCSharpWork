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
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            int x, y;

            x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }

            if ((x % 2 == 0) && (x % 3 == 0) && (x % 4 == 0))
            {
                Console.WriteLine("number {0} divisible with 2, 3 and 4", x);
            }

            Console.WriteLine("Give coordinates of x and y:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > 4 || y > 4)
            {
                Console.WriteLine("Number is outside radius");
            }

            Console.WriteLine("Check if number is prime:");
            x = int.Parse(Console.ReadLine());

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

            string str1;

            str1 = Console.ReadLine();

            if (str1[2] == '3')
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Console.WriteLine("Give two numbers:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > y)
            {
                y = y - x;
                x = x + y;
                y = x - y;
            }
            Console.WriteLine("In order now: {0} and {1}", x, y);

            int z;

            Console.WriteLine("Give three numbers:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            if (x > y && x > z)
            {
                Console.WriteLine("{0} is the biggest", x);
                if (y > z)
                {
                    Console.WriteLine("Sorting {0}, {1}, {2}", z, y, x);
                }
                else
                {
                    Console.WriteLine("Sorting {0}, {1}, {2}", y, z, x);
                }
            }
            else if (y > x && y > z)
            {
                Console.WriteLine("{0} is the biggest", y);
                if (x > z)
                {
                    Console.WriteLine("Sorting {0}, {1}, {2}", z, x, y);
                }
                else
                {
                    Console.WriteLine("Sorting {0}, {1}, {2}", x, z, y);
                }
            }
            else
            {
                Console.WriteLine("{0} is the biggest", z);
                if (x > y)
                {
                    Console.WriteLine("Sorting {0}, {1}, {2}", y, x, z);
                }
                else
                {
                    Console.WriteLine("Sorting {0}, {1}, {2}", x, y, z);
                }
            }

            Console.WriteLine("Give a number from 10 to 19");
            x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 10:
                    Console.WriteLine("number is {0}", x);
                    break;
                case 11:
                    Console.WriteLine("number is {0}", x);
                    break;
                case 12:
                    Console.WriteLine("number is {0}", x);
                    break;
                case 13:
                    Console.WriteLine("number is {0}", x);
                    break;
                case 14:
                    Console.WriteLine("number is {0}", x);
                    break;
                case 15:
                    Console.WriteLine("number is {0}", x);
                    break;
                case 16:
                    Console.WriteLine("number is {0}", x);
                    break;
                case 17:
                    Console.WriteLine("number is {0}", x);
                    break;
                case 18:
                    Console.WriteLine("number is {0}", x);
                    break;
                case 19:
                    Console.WriteLine("number is {0}", x);
                    break;
                default:
                    Console.WriteLine("Number not in corect interval");
                    break;
            }

            int[] arr = new int[5];
            Random random = new Random();
            arr[0] = random.Next(-10, 11);
            arr[1] = random.Next(-10, 11);
            arr[2] = random.Next(-10, 11);
            arr[3] = random.Next(-10, 11);
            arr[4] = random.Next(-10, 11);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j < 5; j++)
                {
                    if (arr[i] + arr[j] == 0)
                    {
                        Console.Write("{0} and {1}{2}", arr[i], arr[j], "\n");
                    }
                }
            }
        }
    }
}
