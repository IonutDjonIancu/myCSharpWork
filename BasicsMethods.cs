using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BasicsMethods
    {
        static void Main(string[] args)
        {
            string str1 = "goood ";
            string str2 = "morning";
            string str3 = String.Concat(str1 + str2 + "!!!");
            Console.WriteLine(str3);

            SayHello();

            var number = Triple(3);
            Console.WriteLine(number);

            Name("Alladin");

            number = Multiply(1, 2, 3);
            Console.WriteLine(number);

            // using a recursive method
            number = Factorial(5);
            Console.WriteLine(number);

            // using a method with a default parameter
            number = MultiplyDefaultParam(10);
            Console.WriteLine(number);

            number = Totalize(1);
            Console.WriteLine(number);
            number = Totalize(1, 2, 3, 4, 5);
            Console.WriteLine(number);
            









        }

        static void SayHello()
        {
            string s = "hello world";
            Console.WriteLine(s);
        }

        static int Triple(int n)
        {
            int result = n * 3;
            return result;
        }

        static void Name(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        static int Multiply(int x, int y, int z)
        {
            int multiply = x * y * z;
            return multiply;
        }

        static int Factorial(int num)
        {
            // recursive method
            int result;
            if (num == 1)
            {
                return 1;
            }
            else
            {
                result = Factorial(num - 1) * num;
                return result;
            }
        }

        static int MultiplyDefaultParam(int x, int y = 3)
        {
            int result;
            result = x * y;
            return result;
        }

        static int Totalize(params int[] numbers)
        {
            int result = 0;
            foreach (int number in numbers)
            {
                result += number;
            }
            return result;
        }





    }
}
