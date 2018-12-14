using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BasicClasses
    {
        static void Main(string[] args)
        {
            Car1 myCar1 = new Car1();
            myCar1.StartEngine1();
            myCar1.color1 = "red";
            Console.WriteLine(myCar1.color1);

            Car2 myCar2 = new Car2("red");
            Console.WriteLine(myCar2.GetDetails());
            myCar2.color2 = "blue";
            Console.WriteLine(myCar2.GetDetails());

            Car3 myCar3 = new Car3();
            myCar3.Color = "blue";
            Console.WriteLine("The new car's color is " + myCar3.Color);

            Car4 myCar4 = new Car4();
            Console.WriteLine(myCar4.GetDetails());

        }


        class Car1
        {
            public string color1;
            public void StartEngine1()
            {
                Console.WriteLine("Vroom!");
            }
        }

        class Car2
        {
            public string color2;

            public Car2(string carColor)
            {
                color2 = carColor;
                StartEngine2();
            }

            public void StartEngine2()
            {
                Console.WriteLine("Vrooom!");
            }

            public string GetDetails()
            {
                return "This car is " + color2;
            }
        }


        class Car3
        {
            // private access is auto-implied
            string color;

            public string Color
            {
                get
                {
                    return color;
                }
                set
                {
                    color = value;
                }
            }
        }


        class Vehicle
        {
            public int wheels = 4;
            public string brand = "Ford";
        }

        class Car4 : Vehicle
        {
            public string GetDetails()
            {
                return "This is a " + brand + " with " + wheels + " wheels";
            }
        }
    }
}
