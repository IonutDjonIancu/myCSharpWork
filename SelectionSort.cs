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
            List<int> arr = new List<int>()
                {
                    8,
                    5,
                    4,
                    2,
                    2
                };

            List<int> sortedList = new List<int>();

            bool isSmallest = false;

            int temp = 0;

            Console.WriteLine("Unsorted list is:");
            Console.WriteLine(string.Join(", ", arr));

            while (sortedList.Count < 5)
            {
                for (int i = 0; i < arr.Count; i++)
                {
                    for (int j = 0; j < arr.Count; j++)
                    {
                        if (arr[i] <= arr[j])
                        {
                            isSmallest = true;
                            temp = arr[i];
                        }
                        else
                        {
                            isSmallest = false;
                            break;
                        }
                    }

                    if (isSmallest == true)
                    {
                        arr.Remove(temp);
                        sortedList.Add(temp);
                        temp = 0;
                        isSmallest = false;
                    }
                }
            }

            Console.WriteLine("Sorted list is:");
            Console.WriteLine(string.Join(", ", sortedList));
        }
    }
}
