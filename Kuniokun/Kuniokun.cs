using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Introduction_to_Programming
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Gray();
            // row 1
            for (int i = 0; i < 22; i++)
            {
                Console.Write("000");
            }
            Console.WriteLine();

            // row 2
            for (int i = 0; i < 22; i++)
            {
                Console.Write("000");
                if (i > 5 && i < 15)
                {
                    Black();
                }
                else if (i > 15)
                {
                    Gray();
                }
            }
            Console.WriteLine();

            // row 3
            for (int i = 0; i < 22; i++)
            {
                Console.Write("000");
                if (i > 4 && i < 13)
                {
                    Black();
                }
                else if (i == 13)
                {
                    Skin();
                }
                else if (i > 13 && i < 17)
                {
                    Black();
                }
                else if (i > 16)
                {
                    Gray();
                }
            }
            Console.WriteLine();

            // row 4
            for (int i = 0; i < 22; i++)
            {
                Console.Write("000");
                if (i > 3 && i < 12)
                {
                    Black();
                }
                else if (i > 11 && i < 15)
                {
                    Skin();
                }
                else if (i > 14 && i < 17)
                {
                    Black();
                }
                else if (i > 16)
                {
                    Gray();
                }
            }
            Console.WriteLine();

            // row 5
            for (int i = 0; i < 22; i++)
            {
                Console.Write("000");
                if (i > 3 && i < 11)
                {
                    Black();
                }
                else if (i > 10 && i < 15)
                {
                    Skin();
                }
                else if (i > 14 && i < 17)
                {
                    Black();
                }
                else if (i > 16)
                {
                    Gray();
                }
            }
            Console.WriteLine();

            // row 6
            for (int i = 0; i < 22; i++)
            {
                Console.Write("000");
                if (i > 4 && i < 9)
                {
                    Black();
                }
                else if (i > 8 && i < 12)
                {
                    Skin();
                }
                else if (i > 11 && i < 14)
                {
                    Black();
                }
                else if (i > 13 && i < 15)
                {
                    Skin();
                }
                else if (i > 14 && i < 17)
                {
                    Black();
                }
                else if (i > 16)
                {
                    Gray();
                }
            }
            Console.WriteLine();

            // row 7
            for (int i = 0; i < 22; i++)
            {
                Console.Write("000");
                if (i > 5 && i < 7)
                {
                    Black();
                }
                else if (i > 6 && i < 11)
                {
                    Skin();
                }
                else if (i > 10 && i < 12)
                {
                    Black();
                }
                else if (i > 11 && i < 14)
                {
                    White();
                }
                else if (i > 13 && i < 15)
                {
                    Skin();
                }
                else if (i > 14 && i < 17)
                {
                    Black();
                }
                else if (i > 16)
                {
                    Gray();
                }
            }
            Console.WriteLine();

            // row 8
            for (int i = 0; i < 22; i++)
            {
                Console.Write("000");
                if (i > 5 && i < 7)
                {
                    White();
                }
                else if (i > 6 && i < 8)
                {
                    Black();
                }
                else if (i > 7 && i < 10)
                {
                    Skin();
                }
                else if (i > 9 && i < 11)
                {
                    Black();
                }
                else if (i > 10 && i < 14)
                {
                    White();
                }
                else if (i > 13 && i < 15)
                {
                    Skin();
                }
                else if (i > 14 && i < 17)
                {
                    Black();
                }
                else if (i > 16)
                {
                    Gray();
                }
            }
            Console.WriteLine();

            // row 9
            for (int i = 0; i < 22; i++)
            {
                Console.Write("000");
                if (i > 5 && i < 7)
                {
                    White();
                }
                else if (i > 6 && i < 8)
                {
                    Black();
                }
                else if (i > 7 && i < 10)
                {
                    Skin();
                }
                else if (i > 9 && i < 11)
                {
                    Black();
                }
                else if (i > 10 && i < 14)
                {
                    White();
                }
                else if (i > 13 && i < 15)
                {
                    Skin();
                }
                else if (i > 14 && i < 16)
                {
                    Black();
                }
                else if (i > 15 && i < 17)
                {
                    Skin();
                }
                else if (i > 16)
                {
                    Gray();
                }
            }
            Console.WriteLine();

            // row 10
            for (int i = 0; i < 22; i++)
            {
                Console.Write("000");
                if (i > 5 && i < 17)
                {
                    Skin();
                }
                else if (i > 16)
                {
                    Gray();
                }
            }
            Console.WriteLine();

            // row 11
            for (int i = 0; i < 22; i++)
            {
                Console.Write("000");
                if (i > 5 && i < 15)
                {
                    Skin();
                }
                else if (i > 14 && i < 18)
                {
                    Black();
                }
                else if (i > 17)
                {
                    Gray();
                }
            }
            Console.WriteLine();

            // row 12
            for (int i = 0; i < 22; i++)
            {
                Console.Write("000");
                if (i > 4 && i < 6)
                {
                    Black();
                }
                else if (i > 5 && i < 14)
                {
                    Skin();
                }
                else if (i > 13 && i < 15)
                {
                    Black();
                }
                else if (i > 14 && i < 18)
                {
                    White();
                }
                else if (i > 17 && i < 19)
                {
                    Black();
                }
                else if (i > 18)
                {
                    Gray();
                }
            }
            Console.WriteLine();

            // row 13
            for (int i = 0; i < 22; i++)
            {
                Console.Write("000");
                if (i > 3 && i < 6)
                {
                    Black();
                }
                else if (i > 5 && i < 7)
                {
                    Skin();
                }
                else if (i > 6 && i < 11)
                {
                    Black();
                }
                else if (i > 10 && i < 13)
                {
                    Skin();
                }
                else if (i > 12 && i < 14)
                {
                    Black();
                }
                else if (i > 13 && i < 19)
                {
                    White();
                }
                else if (i > 18 && i < 20)
                {
                    Black();
                }
                else if (i > 19)
                {
                    Gray();
                }
            }
            Console.WriteLine();

            // row 14
            for (int i = 0; i < 22; i++)
            {
                Console.Write("000");
                if (i > 3 && i < 5)
                {
                    Black();
                }
                else if (i > 4 && i < 6)
                {
                    White();
                }
                else if (i > 5 && i < 7)
                {
                    Black();
                }
                else if (i > 6 && i < 13)
                {
                    Skin();
                }
                else if (i > 12 && i < 14)
                {
                    Black();
                }
                else if (i > 13 && i < 19)
                {
                    White();
                }
                else if (i > 18 && i < 20)
                {
                    Black();
                }
                else if (i > 19)
                {
                    Gray();
                }
            }
            Console.WriteLine();

            // row 15
            for (int i = 0; i < 22; i++)
            {
                Console.Write("000");
                if (i > 2 && i < 6)
                {
                    Black();
                }
                else if (i > 5 && i < 7)
                {
                    White();
                }
                else if (i > 6 && i < 14)
                {
                    Black();
                }
                else if (i > 13 && i < 20)
                {
                    White();
                }
                else if (i > 19 && i < 21)
                {
                    Black();
                }
                else if (i > 20)
                {
                    Gray();
                }
            }
            Console.WriteLine();





















        }

        static void Gray()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Gray;
        }

        static void Black()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        static void White()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.White;
        }

        static void Skin()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Yellow;
        }
    }
}
