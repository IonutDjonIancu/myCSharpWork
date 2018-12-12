using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BasicLists
    {
        static void Main(string[] args)
        { 
            List<double> times = new List<double>
                // initializing a list with initial variables
            {
                4.20,
                7.30,
                9.35
            };
            Console.WriteLine(times[0]);
                // adding new items to the list
            times.Add(10.25);
                // printing a list
                // can only be done after it is transformed into a string
            string s = String.Join(", ", times);
            Console.WriteLine(s);

            List<string> names = new List<string> { "Jon" };
            Console.WriteLine(names[0]);
            names.Add("Catherine");
            names.Add("Margery");
            string d = String.Join("-", names);
            Console.WriteLine(d);
            Console.WriteLine("=============================");
            Console.WriteLine(names[0]);
            Console.WriteLine(names[2]);
            Console.WriteLine("=============================");
                // counting all items in the list
            Console.WriteLine("the list has " + names.Count + " items");
            Console.WriteLine("=============================");

            var days = new List<string>
            {
                "Monday",
                "Wednesday"
            };
                // inserting items to a specific position
            days.Insert(1, "Tuesday");
            days.Insert(3, "Thursday");
            d = String.Join("-", days);
            Console.WriteLine(d);
            Console.WriteLine("=============================");

            var numbers = new List<int>
            {
                10,
                15,
                22,
                7,
                5
            };
            d = String.Join("-", numbers);
            Console.WriteLine(d);
            Console.WriteLine("=============================");
            numbers.Add(44);
            d = String.Join("-", numbers);
            Console.WriteLine(d);
            Console.WriteLine("=============================");
            numbers.Sort();
            d = String.Join("-", numbers);
            Console.WriteLine(d);
            Console.WriteLine("=============================");
            numbers.Remove(44);
            numbers.Remove(numbers[0]);
            d = String.Join("-", numbers);
            Console.WriteLine(d);
            Console.WriteLine("=============================");

            var heroes = new List<string>
            {
                "Magneto",
                "Superman",
                "Batman"
            };
            bool b = heroes.Contains("Superman");
            Console.WriteLine(b);
            Console.WriteLine("=============================");

            var speeds = new List<int>();
            speeds.Add(59);
            speeds.Add(80);
            speeds.Add(100);
            speeds.Add(130);
            var i = speeds.IndexOf(80);
            var j = speeds.IndexOf(130);
            var k = speeds.IndexOf(180);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine("=============================");

            int[] array = { 10, 20, 30, 40 };
            var arrayList = new List<int>(array);
            arrayList.Add(50);
            arrayList.Insert(0, 5);
            d = String.Join(" ", arrayList);
            Console.WriteLine(d);
            Console.WriteLine("=============================");
            arrayList.RemoveAt(1);
            d = String.Join(" ", arrayList);
            Console.WriteLine(d);
            Console.WriteLine("=============================");
        }

    }
}
