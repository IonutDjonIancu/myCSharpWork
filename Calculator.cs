using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Calculator
    {
        static void Main(string[] args)
        {
            // basic math calculator

            Console.Write("choose operator [ \"+\" , \"-\" , \"*\" , \"/\" ]: ");
            string chosenOperator = Console.ReadLine();
            int a, b;

            if (chosenOperator.Equals("+"))
            {
                Console.WriteLine("Enter numbers:");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a + " + " + b + " = " + (a + b));
            }
            else if (chosenOperator.Equals("-"))
            {
                Console.WriteLine("Enter numbers:");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a + " - " + b + " = " + (a - b));
            }
            else if (chosenOperator.Equals("*"))
            {
                Console.WriteLine("Enter numbers:");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a + " * " + b + " = " + (a * b));
            }
            else if (chosenOperator.Equals("/"))
            {
                Console.WriteLine("Enter numbers:");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a + " / " + b + " = " + (a / b));
            }
            else { Console.WriteLine("Wrong operator chosen, program terminated!"); }







            Console.ReadLine();
        }

    }
}
