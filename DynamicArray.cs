using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Udemy Tutorial";

            Console.WriteLine("Give dimension of array:");
            int n = int.Parse(Console.ReadLine());

            int[] myArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Insert element {0}", i);
                myArr[i] = int.Parse(Console.ReadLine());
            }

            foreach (int j in myArr)
            {
                Console.Write("[{0}] ", j);
            }
            Console.WriteLine();
        }
    }
}
