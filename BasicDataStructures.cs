using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BasicDataStructures
    {
        static void Main(string[] args)
        {
            int[] myArray;
            myArray = new int[4];
            myArray[0] = 3;
            Console.WriteLine( myArray[0] );
            Console.WriteLine("============================");

            string[] myStringArray = { "one", "two", "three" };
            Console.WriteLine( myStringArray[1] );
            Console.WriteLine("============================");

            var myIntArray = new int[] { 1, 2, 3, 4, 5 };
            var sJoin1 = String.Join( ", ", myIntArray );
            Console.WriteLine("my string of ints is:\t\t" + sJoin1);


            int[] ages = { 24, 32, 99, 16 };
            Array.Sort(ages);
            var sJoin2 = String.Join( "-", ages );
            Console.WriteLine("my sorted array of ages is:\t" + sJoin2);
            Console.WriteLine("============================");

            string[] superheroes = { "Superman", "Wolverine", "Batman" };
            var arrLength = superheroes.Length;
            Console.WriteLine( arrLength );
            Console.WriteLine( superheroes[0] );
            string oneHero = superheroes[1];
            Console.WriteLine( oneHero );
            Console.WriteLine("============================");

            char[] chars = { 'a', 'b', 'c' };
            string word = new string( chars );
            Console.WriteLine( word );

            int[] ints = { 1, 2, 3 };
            string intWord = String.Join( "-", ints );
            Console.WriteLine( intWord );

            bool check = superheroes[0].Contains("Sup");
            Console.WriteLine(check);

            int check2 = superheroes[0].IndexOf("r");
            Console.WriteLine(check2);

            string superman = "superman is the best of heroes";
            string superman2 = superman.Remove(8);
            Console.WriteLine(superman2);
            string superman3 = superman.Remove(0, 9);
            Console.WriteLine(superman3);
            string superman4 = superman.Replace("man", "girl");
            Console.WriteLine(superman4);

            Console.ReadLine();
        }
    }
}
