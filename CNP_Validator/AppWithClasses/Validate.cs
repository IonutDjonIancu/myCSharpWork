using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNP_Validator
{
    class Validate
    {
        public void Length(string input)
        {
            // length validation
            if (input.Length != 13)
            {
                Err err = new Err();
                err.LengthError();
            }
            else
            {
                Console.WriteLine("Checking...");
            }
        }
    }
}
