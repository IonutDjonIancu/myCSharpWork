using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Write a program that prints all the numbers from 1 to N.
//Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the  same time.

//Write a program that reads from the console a sequence of N integer numbers and returns the minimal  and maximal of them.

//Write a program that calculates N!/K! for given K and N, rules for K and N - 1 < K<N.
//Write a program that calculates N!*K! / (K-N)! for given N and K(1 < N<K).
// Write a program that, for a given two integer numbers N and X, calculates the sum S = 1 + 1!/X + 2!/ X^2 + … + N!/X^N
// Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
// Write a program that prints all possible cards from a standard deck of 52 cards(without jokers). The cards should be printed with their English names.Use nested for loops and switch-case.
// Write a program that reads from the console a positive integer number N(N< 20) and outputs a matrix  like the following:
// n = 3
//     1 2 3
//     2 3 4
//     3 4 5

// n = 4
//     1 2 3 4
//     2 3 4 5
//     3 4 5 6
//     4 5 6 7

// 10. * Write a program that reads a positive integer number N(N< 20) from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.

//n = 4
//        1   2   3  4
//      12 13 14  5
//      11 16 15  6
//      10   9   8  7

namespace Introduction_to_Programming
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e;
            string str1, str2, str3, str4;

            Console.WriteLine("Give a number: ");
            a = int.Parse(Console.ReadLine());
            b = 1;

            while (b <= a)
            {
                Console.WriteLine(b);
                b++;
            }

            Console.WriteLine("Give a number:");
            a = int.Parse(Console.ReadLine());
            b = 1;

            while (b <= a)
            {
                if ((b % 3 == 0) && (b % 7 == 0))
                {
                    b++;
                    continue;
                }
                Console.WriteLine(b);
                b++;
            }

            Console.WriteLine("Give N and K:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            c = 1;
            for (int i = 1; i <= a; i++)
            {
                c *= i;
            }

            d = 1;
            for (int i = 1; i <= b; i++)
            {
                d *= i;
            }

            e = 1;
            for (int i = 1; i < (d - c); i++)
            {
                e *= i;
            }

            Console.WriteLine("N! / K! = {0, 0:N0}", c / d);
            Console.WriteLine("(N! * K!) / (K-N)! = {0, 0:N0}", (c * d) / e);

            Console.WriteLine("Give two numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = 1;

            for (int i = 0; i <= a; i++)
            {
                c += Fact(i) / Math.Pow(b, i);
            }

            Console.WriteLine(Math.Round(c, 1));

            Console.WriteLine("Give a number:");
            a = 0;
            b = 1;
            c = 0;
            d = int.Parse(Console.ReadLine());
            e = 0;

            while (c <= d)
            {
                e += c;
                a = b;
                b = c;
                c = a + b;
            }

            Console.WriteLine("Sum is {0, 0:N0}", e);

            Console.WriteLine("Printing the Deck of Cards:");
            Console.ReadLine();

            for (int i = 2; i < 15; i++)
            {
                switch (i)
                {
                    case 11:
                        for (int j = 0; j < 4; j++)
                        {
                            Console.Write("[{0}] ", "A");
                        }
                        Console.WriteLine();
                        break;
                    case 12:
                        for (int j = 0; j < 4; j++)
                        {
                            Console.Write("[{0}] ", "J");
                        }
                        Console.WriteLine();
                        break;
                    case 13:
                        for (int j = 0; j < 4; j++)
                        {
                            Console.Write("[{0}] ", "Q");
                        }
                        Console.WriteLine();
                        break;
                    case 14:
                        for (int j = 0; j < 4; j++)
                        {
                            Console.Write("[{0}] ", "K");
                        }
                        Console.WriteLine();
                        break;

                    default:
                        for (int j = 0; j < 4; j++)
                        {
                            Console.Write("[{0}] ", i);
                        }
                        Console.WriteLine();
                        break;
                }
            }

            Console.WriteLine("Give a number less 20:");
            a = int.Parse(Console.ReadLine());

            if ((a <= 0) || (a >= 20))
            {
                Console.WriteLine("Number out of bounds.");
            }
            else
            {
                for (int i = 1; i <= a; i++)
                {
                    b = i;
                    for (int j = 1; j <= a; j++)
                    {
                        Console.Write("{0} ", b);
                        b++;
                    }
                    Console.WriteLine();
                }
            }

            int x, y;
            x = 3;
            y = 3;
            int[,] arr = new int[x, y];

            arr[0, 0] = 1;
            arr[0, 1] = 2;
            arr[0, 2] = 3;
            arr[1, 0] = 4;
            arr[1, 1] = 5;
            arr[1, 2] = 6;
            arr[2, 0] = 7;
            arr[2, 1] = 8;
            arr[2, 2] = 9;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[{0}]", arr[i, j]);
                }
                Console.WriteLine();
            }












        }

        static double Fact(double num)
        {
            double prod = 1;
            for (int i = 1; i <= num; i++)
            {
                prod *= i;
            }

            return prod;
        }
    }
}
