using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Inheritance.Models
{
    public class Animal
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public string Type { get; set; }
        public string Race { get; set; }

        public Animal()
        {
            Console.WriteLine("A new instance of an animal has been created. This is the animal constructor");
        }

        public Animal(string name, string type, string race)
        {
            Name = name;
            Type = type;
            Race = race;
            Console.WriteLine("A new instance of an animal has been created. This is the animal constructor");
        }

        public virtual void Eat()
        {
            Console.WriteLine($"The {Type} animal named {Name} is eating.");
        }
    }
}
