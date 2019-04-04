using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNP_Validator
{
    public class UserIO
    {
        public string AskCNP()
        {
            Console.WriteLine("Enter a CNP:");
            string input = Console.ReadLine();
            return input;
        }

        public void ReturnValidCNP()
        {

        }

        public void ReturnInvalidCNP()
        {

        }
    }
}
