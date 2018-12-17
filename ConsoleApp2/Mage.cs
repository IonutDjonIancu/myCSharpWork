using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Mage
    {
        public Mage(string name, double hp, double dmg)
        {
            Name = name;
            Hp = hp;
            Dmg = dmg;
        }

        public string Name { get; set; }
        public double Hp { get; set; }
        public double Dmg { get; set; }

    }
}
