using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Declare a variable for each of the data types in this section and assign an appropriate value. - Int, Float, Double,  Bool, Char, String, Object
// Read two double numbers from the console.Write a program to successfully compare these numbers with precision of  0.0001. e.g. 3.006 and 3.1 false, 3.00007 and 3.00008 true
// Create a character variable and assign it with the character with Unicode 91. 
// Declare a boolean variable isMyCatAlive and give it an appropriate value, depending on if your cat is or isn't alive.
// Declare two string variables and assign them with “C#” and “Course”. Declare an object variable and assign it with the  concatenation of the first two variables (mind adding an interval between the words). Declare a third string variable  and initialize it with the value of the object variable (you should perform type casting).
// Draw on the console a 5 by 5 rectangle with the symbol "?".
// Read two integer values from the console, save their values in variables, and then exchange the values of these  variables. If the first variable had the value 1 and the second variable had the value 2, after the exchange, the  first variable should get the value 2 and the second variable should get the value 1. 


namespace UdemyTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            program.SwapNumbers(22, 33);            
        }
        
        void SwapNumbers(int a, int b)
        {
            Console.WriteLine("Numbers before swapping are: {0}, {1}", a, b);

            b = b - a;
            a = a + b;
            b = a - b;

            Console.WriteLine("Numbers after swapping are: {0}, {1}", a, b);
        }
    }
}
