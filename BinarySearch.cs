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
            int[] arr = { 5, 8, 7, 2 };

            Array.Sort(arr); // uses bubble sort => 2, 5, 7, 8

            List<int> myList = arr.ToList();

            Console.WriteLine("What number are we searching for?");
            int searchedNumber = int.Parse(Console.ReadLine());

            while (myList.Count > 1)
            {
                if (searchedNumber < myList[myList.Count / 2])
                {
                    for (int i = myList.Count / 2; i < myList.Count; i++)
                    {
                        myList.RemoveAt(i);
                    }
                }
                else if (searchedNumber > myList[myList.Count / 2])
                {
                    for (int i = myList.Count / 2; i >= 0; i--)
                    {
                        myList.RemoveAt(i);
                    }
                }
                else if (searchedNumber == myList[myList.Count / 2])
                {
                    Console.WriteLine("Number found at index: {0}", myList.Count / 2);
                    break;
                }
            }

            if (myList.Count == 1 && searchedNumber != myList[0])
            {
                Console.WriteLine("Number was not found in list.");
            }
            else
            {
                Console.WriteLine(string.Join(", ", myList));
            }
        }
    }
}
