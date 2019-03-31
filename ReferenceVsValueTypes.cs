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
            // VALUE TYPES
            // these values will be stored physically in two separate places
            int num1 = 5; // this will allocate 4 bytes of memory to hold an int type of value 5
            int num2 = num1; // this will alloca 4 bytes of memory to hold an int type of value num1

            num1++;

            Console.WriteLine(num1); // will result 6 since an unary operation was performed on it
            Console.WriteLine(num2); // will result in the old value 5 since no operation was performed

            // REFERENCE TYPES
            int[] arr1 = { 1, 2, 3 }; // will allocate 3 contiguous spaces of 4 bytes to store the ints
            int[] arr2 = arr1; // will allocate 4 bytes for the pointer of arr2 to point to the address of arr1

            arr1[0] = 5; // this will change the value from the address that arr1 points at

            Console.WriteLine(arr2[0]); // the arr2 pointer will go to the address of arr1 and then point to the address of arr1[0] returning the type found at that address
        }        
    }
}
