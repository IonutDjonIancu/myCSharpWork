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
            // why should we use interfaces? @_@

            RunApp();

        }

        public static void RunApp()
        {
            UserIO user = new UserIO();
            Validate validate = new Validate();
            Storage storage = new Storage();
            Color color = new Color();

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            storage.SetCNP(user.AskCNP()); // ask and store cnp
            Console.CursorVisible = false;
            validate.Length(storage.GetCNP()); // validate for the length

            storage.SetCNPList(storage.GetCNP().Substring(0, 1)); // splitting the cnp in substrings and storing them in a list
            storage.SetCNPList(storage.GetCNP().Substring(1, 2));
            storage.SetCNPList(storage.GetCNP().Substring(3, 2));
            storage.SetCNPList(storage.GetCNP().Substring(5, 2));
            storage.SetCNPList(storage.GetCNP().Substring(7, 2));
            storage.SetCNPList(storage.GetCNP().Substring(9, 3));
            storage.SetCNPList(storage.GetCNP().Substring(12, 1));

            foreach (var item in storage.GetCNPList())
            {
                Console.WriteLine(item);
            }
               

        }
    }
}
