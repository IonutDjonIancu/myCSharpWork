using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Log
    {
        public Log()
        { }

        public static double Attack(double hpAttacked, double dmgAttacker)
        {
            return hpAttacked - dmgAttacker;
        }

        public static void AttackVerbose
            (
                string nameAttacker,
                string nameAttacked,
                double hpAttacked,
                double dmgAttacker
            )
        {
            Console.WriteLine
                (
                    nameAttacker +
                    " attacks " +
                    nameAttacked +
                    " for " +
                    dmgAttacker +
                    " damage." 
                );
            Console.WriteLine
                (
                    nameAttacked +
                    " has " +
                    (hpAttacked - dmgAttacker) +
                    " hp left." +
                    "\n======================================"
                );
        }

        


        


    }
}
