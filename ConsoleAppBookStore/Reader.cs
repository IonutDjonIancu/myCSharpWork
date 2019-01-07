using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Reader
    {
        //class attributes
        public string name;
        public double hour;
        public char category;

        public Reader(string aName, double aHour, char aCategory)
        {
            name = aName;
            hour = aHour;
            category = aCategory;
        }

        // object method
        public bool IsAfter8WithRETURN()
        {
            if (hour >= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void IsAfter8NoRETURN()
        {
            if (hour >= 20)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public char ModifyBookCategory(char aCategory)
        {
            category = aCategory;
            return category;
        }


    }
}
