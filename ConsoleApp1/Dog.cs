using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dog
    {
        string name;
        int age;

        public Dog(string dogName, int dogAge)
        {
            this.name = dogName;
            this.age = dogAge;
        }
        public void Bark()
        {
            Console.WriteLine("Woof!");
        }

    }
}
