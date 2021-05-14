using System;
using System.Collections.Generic;
using System.Threading;

namespace InheritTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog(), new Dog()
            };
            List<Cat> cats = new List<Cat>()
            {
                new Cat(), new Cat()
            };
            foreach (var item in dogs)
            {
                item.Age = 10;
                item.Color = "흰색";
                item.Eat();
                item.Sleep();
                item.Bark();
                Console.WriteLine(item.Age + " " + item.Color);

            }
            Console.WriteLine("\n");
            foreach (var item in cats)
            {
                item.Age = 5;
                item.Eat();
                item.Sleep();
                item.Meow();
                Console.WriteLine(item.Age);

            }

        }
    }
}
