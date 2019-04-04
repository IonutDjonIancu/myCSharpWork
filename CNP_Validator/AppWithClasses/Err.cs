using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CNP_Validator
{
    class Err
    {
        // Generic error in length validation
        public void LengthError()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Program halt! CNP has wrong length.");
                Thread.Sleep(500);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Program halt! CNP has wrong length.");
                Thread.Sleep(500);
            }
            Environment.Exit(1);
        }

    }
}
