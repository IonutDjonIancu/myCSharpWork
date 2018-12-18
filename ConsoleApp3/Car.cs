using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
       
        // car: color, date, number, carClass
        public Car(string name, string color, int date, double number, char carClass)
        {
            Name = name;
            Color = color;
            Date = date;
            Number = number;
            CarClass = carClass;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public int Date { get; set; }
        public double Number { get; set; }
        public char CarClass { get; set; }

        public void SetColor(string color)
        {
            Color = color;
        }


    }
}
