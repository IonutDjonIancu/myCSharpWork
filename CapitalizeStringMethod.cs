using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Udemy Tutorial";

            string stringName = "GaNdaLf";

            //Console.WriteLine(stringName.IndexOf('a'));
            //Console.WriteLine(stringName.LastIndexOf('a'));
            //Console.WriteLine(stringName.ToLower());
            //Console.WriteLine(stringName.ToUpper());
            //Console.WriteLine(stringName.First());

            Program program = new Program();

            Console.WriteLine(program.Capitalize(stringName));




        }

        string Capitalize(string input)
        {
            string temp = input.ToUpper();
            char x = temp[0];
            temp = x + (input.Substring(1, input.Length - 1)).ToLower();
            return temp;           
        }


    }
}
