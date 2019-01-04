using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GuessGame
    {
        static void Main(string[] args)
        {
            string secretMessage = "apothecary";
            string guess = null;
            int guessCounter = 4;

            do
            {
                Console.Write("guess the word: ");
                guess = Console.ReadLine();
                guessCounter--;

            }
            while (guess != secretMessage && guessCounter>0);

            if (guess.Equals(secretMessage))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }


            Console.ReadLine();
        }
    }
}
