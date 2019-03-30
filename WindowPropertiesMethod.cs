using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UdemyTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.WindowSet("Udemy Tutorial", 50, 20);

        }

        void WindowSet(string title, int width, int height)
        {
            Console.Title = title;
            Console.SetWindowSize(width, height);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }
    }
}
