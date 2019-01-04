using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SwitchStatement
    {
        static void Main(string[] args)
        {
            Console.Write("Select option \n[1]Character creation \n[2]Show map \n[3]Dungeons \n[4]Quit game\n");
            int number = Convert.ToInt32(Console.ReadLine());

            MenuOptions(number);




            Console.ReadLine();
        }

        static int MenuOptions(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("Character generator!");
                    break;
                case 2:
                    Console.WriteLine("Map of realm selected!");
                    break;
                case 3:
                    Console.WriteLine("Dungeon generator!");
                    break;
                case 4:
                    Console.WriteLine("Good bye you little shit!");
                    break;
                default:
                    Console.WriteLine("Invalid option selected!");
                    break;
            }

            return number;
        }







    }
}
