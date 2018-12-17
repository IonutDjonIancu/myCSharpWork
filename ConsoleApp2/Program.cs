using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // mage: name, level, spell

            Mage Merlin = new Mage("Merlin", 10, 1.25);
            double merlinHp = Merlin.Hp;
            Mage Gandalf = new Mage("Gandalf", 15, 2.25);
            double gandalfHp = Gandalf.Hp;

            while (true)
            {
                Log.AttackVerbose(Merlin.Name, Gandalf.Name, Gandalf.Hp, Merlin.Dmg);
                gandalfHp = Log.Attack(Gandalf.Hp, Merlin.Dmg);
                Gandalf.Hp = gandalfHp;

                Log.AttackVerbose(Gandalf.Name, Merlin.Name, Merlin.Hp, Gandalf.Dmg);
                merlinHp = Log.Attack(Merlin.Hp, Gandalf.Dmg);
                Merlin.Hp = merlinHp;

                if (Gandalf.Hp < 0)
                {
                    Console.WriteLine("Gandalf dies X_X");
                    break;
                }
                else if (Merlin.Hp < 0)
                {
                    Console.WriteLine("Merlin dies X_X");
                    break;
                }
            }
        }
    }
}
