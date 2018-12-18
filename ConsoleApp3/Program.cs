using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // car: color, date, number, class

            Car Ferarri = new Car("Ferarri", "red", 2018, 123.45, 'A');
            Car Lamborghini = new Car("Lamborghini", "black", 2017, 100.8, 'B');


            List<string> carShop = new List<string>
            {
                Ferarri.Name,
                Lamborghini.Name
            };
            List<string> carColors = new List<string>
            {
                Ferarri.Color,
                Lamborghini.Color,
                "yellow"
            };

            string carShopPrint = String.Join(", ", carShop);
            Console.WriteLine("Available cars in shop: " + carShopPrint);
            string carColorsPrint = String.Join("-", carColors);
            Console.WriteLine("Available colors in shop: " + carColorsPrint);

            string s = carColors[2];

            Ferarri.SetColor(s);

            carColors = new List<string>
            {
                Ferarri.Color,
                Lamborghini.Color,
                "green"
            };
            

            carShopPrint = String.Join("-", carColors);
            Console.WriteLine("Available colors in shop after repaint: " + carShopPrint);





        }

    }
}
