namespace Introduction_to_Programming
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

    class EntryPoint
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 78, 1, -1 };

            int temp = 0;

            Console.WriteLine("Unsorted array:");
            Console.WriteLine(string.Join(" ", arr));

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted array:");
            Console.WriteLine(string.Join(" ", arr));



        }
    }
}
