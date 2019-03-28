using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// Create several strings that contain words and sentences.Utilize Write and WriteLine to correctly construct sentences  from the words, print them and print the already constructed sentences. Do NOT use string concatenation
// Take the string given in the Hints: 2) section and correctly escape all characters that need escaping, so that you can  output it on the console as shown in the screenshot.
// Ask two inputs from the user, "Name of the Program: " (string) and "Local Drive Letter: " (character), use the  information that was input to reconstruct your string from the previous exercise.
// You are given a set of strings and numbers.Align them in such way that they look like a column from a table, limit the  numbers after the decimal point to only 2 numbers and include a currency for the total.
// Take the example from the previous exercise and colorize it. Add color to the characters and add different background  for the borders, separations, title, data and total.Optionally try and extract these colors into variables, that will  not change the way its being output, but it will make it easier to change colors, if you want to, because you will  have to change the color only in the variable. 
// Make the size of the console variable so that it always wraps around the text that is output on it and no additional  free spaces.


namespace UdemyTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.WindowSet("Udemy Tutorial", 50, 20);

            //string str1 = "We";
            //string str2 = " are here";
            //string str3 = " to stay.";
            //string str4 = "Said the trees.";

            //Console.Write(str1);
            //Console.Write(str2);
            //Console.WriteLine(str3);
            //Console.WriteLine(str4);

            //Console.WriteLine("\"C:\\Program Files\\\"Microsoft Programs\"\\'VisualStudio'\"");

            //str1 = "\"C:\\Program Files\\\"Microsoft Programs\"\\'VisualStudio'\"";
            //Console.Write("Name of the program: ");
            //str2 = Console.ReadLine();
            //Console.Write("Local Drive Letter: ");
            //char str5 = (char)Console.Read();

            //str1 = "\"" + str5 + ":\\Program Files\\\"" + str2 + "\"\\'VisualStudio'\"";

            //Console.WriteLine(str1);
            //Console.Clear();

            program.ProteinCalculator(7);















        }

        void WindowSet(string title, int width, int height)
        {
            Console.Title = title;
            Console.SetWindowSize(width, height);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }

        void ProteinCalculator (int intakes)
        {
            double sum = 0;
            double[] intakesArr = new double[intakes];


            Program program = new Program();

            for (int i = 0; i < intakes; i++)
            {
                Console.Write("Give intake {0}: ", i + 1);
                intakesArr[i] = double.Parse(Console.ReadLine());
                sum += intakesArr[i];
            }
            Console.Clear();
            Console.SetWindowSize(25, intakes + 8);
            Console.SetBufferSize(25, intakes + 8);

            program.Color(ConsoleColor.DarkMagenta);
            Console.WriteLine("|======================|");
            Console.Write("|");

            program.Color(ConsoleColor.Yellow);
            Console.Write("Protein Intake Week: 1");

            program.Color(ConsoleColor.DarkMagenta);
            Console.WriteLine("|");
            Console.WriteLine("|======================|");

            for (int j = 0; j < intakes; j++)
            {
                Console.Write("|");

                program.Color(ConsoleColor.Green);
                Console.Write("{0, 22}", Math.Round(intakesArr[j], 2));

                program.Color(ConsoleColor.DarkMagenta);
                Console.WriteLine("|");

            }
            Console.WriteLine("|======================|");

            Console.Write("|");

            program.Color(ConsoleColor.Blue);
            Console.Write("Total: {0, 15:C}", Math.Round(sum, 2));

            program.Color(ConsoleColor.DarkMagenta);
            Console.WriteLine("|");

            Console.WriteLine("|======================|");
            program.Color(ConsoleColor.White);
        }

        void Color(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }



    }
}
