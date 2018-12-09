using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BasicConditionals
    {
        static void Main(string[] args)
        {
            if ( true )
            { Console.WriteLine( "condition met with true" ); }

            string var1 = "level 1";
            if (var1 == "level 1")
            { Console.WriteLine( "level 1 condition met with true" ); }

            var var2 = 2;
            if (var2 > 3)
            { Console.WriteLine("level unlocked"); }
            else
            { Console.WriteLine( "level locked" );  }

            Console.WriteLine("==============================");

            var var3 = 1;
            while (true)
            {
                var3++;
                Console.WriteLine( var3 );
                if (var3 == 10)
                { break; }
            }

            Console.WriteLine( "==============================" );

            for (var i = 0; i <= 5; i++)
            {
                Console.WriteLine( i );
            }

            Console.WriteLine("==============================");

            var var4 = new int[] { 90, 60, 30 };
            for ( var j = 0; j < 3; j++ )
            {
                Console.WriteLine( var4[j] );
            }






            Console.ReadLine();
        }
    }
}
