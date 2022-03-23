using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Inheritance.Models
{
    public class Dog : Animal
    {
        public bool isPlayfull { get; set; }

        public Dog()
        {
            Console.WriteLine("A new instance of dog is created by the parent constructor Animal.");
        }

        public Dog(string name, string type)
            :base(name, type, "Doggy")
        {
            isPlayfull = false;
            Console.WriteLine("A new instance of dog is created by the parent constructor Animal with params.");
        }
        
        public void DogEat()
        {
            Console.WriteLine("Dog eats food!");
            base.Eat();
        }
    }
}
