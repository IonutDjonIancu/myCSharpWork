using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BasicsDictionaries
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> myDict = new Dictionary<string, int>();

            var myDict2 = new Dictionary<int, string>()
            {
                { 23, "Michael" },
                { 25, "John" },
                { 31, "Deborah" }
            };
            myDict2.Remove(25);
            var a = String.Join("-", myDict2);
            Console.WriteLine(a);
            Console.WriteLine("==========================");


            var myDict3 = new Dictionary<string, int>()
            {
                { "Goalkeeper", 1 },
                { "Midfielder", 2 },
                { "Forward", 3}
            };
            myDict3.Add("Reserve", 4);
            Console.WriteLine(myDict3["Goalkeeper"]);
            Console.WriteLine(myDict3["Reserve"]);
            Console.WriteLine("==========================");

            var myDict4 = new Dictionary<string, string>()
            {
                { "bob", "bagdad" },
                { "carmen", "madrid" },
                { "olga", "milan" }
            };
            Console.WriteLine(myDict4.Count);
            var s = String.Join(", ", myDict4.Keys);
            Console.WriteLine(s);
            s = String.Join(", ",myDict4.Values);
            Console.WriteLine(s);
            myDict4.Clear();
            Console.WriteLine(myDict4.Count);
            Console.WriteLine("==========================");

            var age = new Dictionary<string, int>()
            {
                { "infant", 3 },
                { "kid", 14 },
                { "teen", 18 }
            };
            Console.WriteLine(age.Count);
            bool d = age.ContainsKey("kid");
            Console.WriteLine(d);
            d = age.ContainsValue(18);
            Console.WriteLine(d);
            d = age.ContainsValue(20);
            Console.WriteLine(d);
            Console.WriteLine("==========================");

            var cSharp = new Dictionary<string, bool>()
            {
                { "Fun", true },
                { "Boring", false },
                { "Toys", true }
            };
            cSharp.Remove("Boring");
            s = String.Join(", ", cSharp);
            Console.WriteLine(s);
            cSharp.Add("School", false);
            s = String.Join(", ", cSharp);
            Console.WriteLine(s);
            s = String.Join("-", cSharp.Keys);
            Console.WriteLine(s);
            d = cSharp.ContainsKey("Toys");
            Console.WriteLine(d);




        }
    }
}
