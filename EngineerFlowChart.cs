using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // engineer flowchart using only booleans
    class EngineerFlowChart
    {
        static void Main(string[] args)
        {
            bool doesItMove = false;
            bool shouldItLeft = false;
            bool shouldItRight = false;

            if (doesItMove == true)
            {
                if (shouldItRight == true)
                {
                    Console.WriteLine("No Problem");
                }
                else
                {
                    Console.WriteLine("Apply ductape");
                }
            }
            else
            {
                if (shouldItLeft == true)
                {
                    Console.WriteLine("Apply WD-40");
                }
                else
                {
                    Console.WriteLine("No Problem");
                }
            }

            








            Console.ReadLine();
        }

    }
}
