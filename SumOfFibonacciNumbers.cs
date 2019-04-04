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
            double a, b, c, d, e;
            string str1, str2;

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
        }
    }
}
