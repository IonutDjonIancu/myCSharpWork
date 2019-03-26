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
            Console.Title = "Udemy Tutorial";

            int myInt1 = 23;
            int myInt2 = 0;
            // float myFloat = 12.44F;
            double myDouble1 = 3000D;
            double myDouble2 = 3000D;
            // bool myBoolIsTrue = true;
            char myChar = 'A';
            // string myString = "Gandalf";
            object myObject = null;

            // the dash delimiter
            string dash = new string('-', 20);

            Console.WriteLine("Give two double numbers:");
            myDouble1 = Convert.ToDouble(Console.ReadLine());
            myDouble2 = Convert.ToDouble(Console.ReadLine());

            myDouble1 = Math.Round(myDouble1, 4);
            myDouble2 = Math.Round(myDouble2, 4);

            if (myDouble1 == myDouble2)
            {
                Console.WriteLine("{0} = {1}", myDouble1, myDouble2);
            }
            else
            {
                Console.WriteLine("{0} != {1}", myDouble1, myDouble2);
            }

            Console.WriteLine(dash);

            myChar = (char)91;
            Console.WriteLine(myChar);

            Console.WriteLine(dash);

            bool isMyCatAlive = true;
            Console.WriteLine(isMyCatAlive);

            Console.WriteLine(dash);

            string str1 = "C#";
            string str2 = "Course";

            myObject = str1 + " " + str2;

            string str3 = myObject.ToString();
            Console.WriteLine(str3);

            Console.WriteLine(dash);

            myChar = '?';
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(myChar);
                }
                Console.WriteLine();
            }

            Console.WriteLine(dash);

            Console.WriteLine("Give two int values:");
            myInt1 = Convert.ToInt32(Console.ReadLine());
            myInt2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping\n{0} and {1}", myInt1, myInt2);

            myInt2 = myInt2 - myInt1;
            myInt1 = myInt1 + myInt2;
            myInt2 = myInt1 - myInt2;

            Console.WriteLine("After swapping\n{0} and {1}", myInt1, myInt2);
        }               
    }
}
