using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Inheritance.Models
{
    public class Cat : Animal
    {
        public bool IsLazy { get; set; }

        public Cat()
        {
            Console.WriteLine("A new instance of cat is created by the parent constructor Animal.");
        }

        public Cat(string name, string type, string race, bool isLazy)
            :base(name, type, race)
        {
            IsLazy = isLazy;
            Console.WriteLine("A new instance of cat is created by the parent constructor Animal with params.");
        }

        public override void Eat()
        {
            if (IsLazy)
            {
                Console.WriteLine("we need to feed the cat with a spoon");
            }
            else
            {
                Console.WriteLine("The cat is eating the food");
            }
        }
    }
}
