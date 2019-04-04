using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CNP_Validator
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            /// validator app logic
            // user enters information
            // length validation
            // int validation
            // information is stored
            // a result is sent back to the user

            // getting information from user
            Console.WriteLine("Enter a CNP:");
            string cnp = Console.ReadLine();

            // length validation
            if (cnp.Length != 13)
            {
                Console.WriteLine("Generic error in length validation");
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Checking...");
            }

            // storing information
            // splitting the cnp in substrings and adding them in a list
            List<string> cnpList = new List<string>
            {
                cnp.Substring(0, 1),
                cnp.Substring(1, 2),
                cnp.Substring(3, 2),
                cnp.Substring(5, 2),
                cnp.Substring(7, 2),
                cnp.Substring(9, 3),
                cnp.Substring(12, 1)
            };

            // int validation, this will only check if the pairs of numbers can be converted to int
            foreach (var n in cnpList)
            {
                if (int.TryParse(n, out int i))
                {
                    Console.WriteLine("verifying number");
                    Thread.Sleep(500);
                    Console.WriteLine(n);
                }
                else
                {
                    Console.WriteLine("Generic error in substring in pairs validation");
                    Environment.Exit(1);
                }
            }

            // performing numerical validations for each set of numbers, the source will be the cnpList considering that we already know the numbers are correct
            int temp = 0;
            temp = Convert.ToInt32(cnpList[0]);
            if (temp < 1 || temp > 8)
            {
                Console.WriteLine("Generic error in gender pair, number out of bounds");
                Environment.Exit(1);
            }

            // no need to validate year since they all come in 00 to 99 pairs

            temp = Convert.ToInt32(cnpList[2]);
            if (temp < 1 || temp > 12)
            {
                Console.WriteLine("Generic error in month pair, number out of bounds");
                Environment.Exit(1);
            }

            temp = Convert.ToInt32(cnpList[3]);
            if (temp < 1 || temp > 31)
            {
                Console.WriteLine("Generic error in day pair, number out of bounds");
                Environment.Exit(1);
            }

            temp = Convert.ToInt32(cnpList[4]);
            if (temp < 1 || temp > 52)
            {
                Console.WriteLine("Generic error in county pair, number out of bounds");
                Environment.Exit(1);
            }

            // no need to validate the arbitrary 3 numbers since they can only be between 1 and 999

            // no need to validate the control number since it can only be between 1 and 9

            // performing special validations, such as:
            // a person born in a future year 
            temp = Convert.ToInt32(cnpList[0]);
            if (temp == 5 || temp == 6)
            {
                DateTime date = DateTime.Now;
                string yearStr = date.Year.ToString();
                yearStr = yearStr.Substring(2, 2);

                int yearInt = Convert.ToInt32(yearStr);

                temp = Convert.ToInt32(cnpList[1]);
                if (temp > yearInt)
                {
                    Console.WriteLine("Generic error in year pair, cannot be born in the future");
                    Environment.Exit(1);
                }
            }
            // born on Feb 31
            temp = Convert.ToInt32(cnpList[2]);
            if (temp == 2)
            {
                temp = Convert.ToInt32(cnpList[3]);
                if (temp > 29)
                {
                    Console.WriteLine($"Generic error in day pair, cannot be born on {temp} February");
                    Environment.Exit(1);
                }
            }
            // control digit
            int controlDigit = 0;
            int sum = 0;

            string cnpSubstring = cnp.Substring(0, 12);
            string comparer = "279146358279";

            for (int i = 0; i < cnpSubstring.Length; i++)
            {
                sum += int.Parse(cnpSubstring[i].ToString()) * int.Parse(comparer[i].ToString());
            }

            if (sum % 11 == 10)
            {
                controlDigit = 1;
            }
            else
            {
                controlDigit = sum % 11;
            }

            if (int.Parse(cnpList[6]) != controlDigit)
            {
                Console.WriteLine("Generic error in control digit, invalid CNP");
                Environment.Exit(1);
            }

            // returning information to user
            Console.WriteLine($"The CNP is valid: {cnp}");
        }
    }
}
