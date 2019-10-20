using System;
using System.Collections.Generic;
using System.Linq;

namespace BitAcad_course1
{
    class BitAcad_ex1
    {
        static void Main(string[] args)
        {
            #region ex_1

            //var age = Console.ReadLine();

            //Console.WriteLine($"Aveti {age} de ani.");

            #endregion

            #region ex_2

            //int num1 = 10;
            //int num2 = 10;
            //float num3 = 12.5F;
            //string myString = "programare C#";

            //Console.WriteLine(num1);
            //Console.WriteLine(num3);
            //Console.WriteLine(myString);

            #endregion

            #region ex_3

            //Console.WriteLine("1******");
            //Console.WriteLine("12*****");
            //Console.WriteLine("123****");
            //Console.WriteLine("1234***");
            //Console.WriteLine("12345**");
            //Console.WriteLine("123456*");
            //Console.WriteLine("1234567");

            #endregion

            #region ex_4

            //// !!! cannot use implicit conversion from float to short
            //// Implicit conversions don't require special syntax to be invoked and can occur in a variety of situations
            //// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/user-defined-conversion-operators

            //float a = 3.5F;
            //bool isA = true;

            //Console.WriteLine((short)a);
            //Console.WriteLine(isA.ToString());
            //Console.WriteLine(a.ToString());

            #endregion

            #region ex_5

            //int[] myArr = new int[10];
            //int sum = 0;

            //for (int i = 0; i < myArr.Length; i++)
            //{
            //    Console.WriteLine($"Add number {i+1}:");
            //    myArr[i] = int.Parse(Console.ReadLine());
            //    sum += myArr[i];
            //}

            //Console.WriteLine($"Sum is = {sum}");
            //Console.WriteLine($"Average is = {(float)sum/myArr.Length}");

            #endregion

            #region ex_6

            //int op1, op2;
            //char sign;

            //Console.Write("Enter first number: ");
            //op1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter sign: ");
            //sign = char.Parse(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //op2 = int.Parse(Console.ReadLine());

            //if (sign == '+')
            //{
            //    Console.WriteLine($"Result of the operation {op1} + {op2} = {op1 + op2}");
            //}
            //if (sign == '-')
            //{
            //    Console.WriteLine($"Result of the operation {op1} - {op2} = {op1 - op2}");
            //}

            #endregion

            #region ex_7

            //int a, b, c;

            //Console.WriteLine("Enter interval segment:");
            //a = int.Parse(Console.ReadLine());
            //b = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter number:");
            //c = int.Parse(Console.ReadLine());

            //if (c >= a && c <= b)
            //{
            //    Console.WriteLine("Number is between the selected segment.");
            //}

            #endregion

            #region ex_8

            //Console.WriteLine("Insert number");
            //string number = Console.ReadLine();

            //try
            //{
            //    int.Parse(number);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("That's not a number\n" + e);
            //}

            //if (number[0] == '-')
            //{
            //    Console.WriteLine(CountEvenDigits(number.Substring(1)));
            //}
            //else
            //{
            //    Console.WriteLine(CountEvenDigits(number));
            //}

            #endregion

            #region ex_9
            
            //Console.WriteLine("Enter a positive number:");
            //string num = Console.ReadLine();

            //if (int.Parse(num) < 0)
            //{
            //    throw new Exception("Must be a positive number.");
            //}

            //int foundIndex = 0;
            //int lowest = num[0];

            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (Convert.ToInt32(num[i]) <= Convert.ToInt32(lowest))
            //    {
            //        foundIndex = i;
            //        lowest = num[i];
            //    }
            //}

            //Console.WriteLine(num.Remove(foundIndex, 1));

            #endregion
        }

        #region custom_methods

        /// <summary>
        /// Returns the number of even digits from a given input.
        /// </summary>
        /// <param name="input"></param>
        public static int CountEvenDigits(string input)
        {
            var count = 0;

            foreach (var item in input)
            {
                if (Convert.ToInt32(item) % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }

        #endregion
    }
}
