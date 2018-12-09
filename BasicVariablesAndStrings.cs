using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string varString1 = "this is a string format";
            Console.WriteLine( varString1 );

            var varString2 = "this is also a string format";
            Console.WriteLine( varString2 );

            int varInt1 = 5;
            Console.WriteLine( varInt1 );

            Console.WriteLine( "A " + varString1 + "\n\tB " + varString2 + ' ' + varInt1);

            var varInt2 = 8;    // 8.0 will be treated as a float
            var varInt3 = 3.0;  // 3.0 this will be treated as a double
            var varInt4 = varInt2 / varInt3;
            Console.WriteLine( varInt4 );

            Console.WriteLine( "apples" == "oranges" );
            var varBool1 = "apples" == "apples";
            Console.WriteLine( varBool1 );

            var varBool2 = varInt2 == 10;
            Console.WriteLine( varBool2 );




            Console.ReadLine();
        }
    }
}
