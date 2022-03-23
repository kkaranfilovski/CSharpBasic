using SEDC.Oop.Class07.Inheritance.Models;
using System;

namespace SEDC.Oop.Class07.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal animal = new Animal() {Name = "Dambo", Id = 5, Type = "Elephant", Race = "WhiteOnes" };
            animal.Eat();

            Dog dog = new Dog()
            {
                Name = "Sparky",
                Id = 2,
                Type = "Dog",
                Race = "Striter",
                isPlayfull = true
            };

            dog.Eat();
            //dog.DogEat();
            Console.WriteLine();

            Cat cat = new Cat()
            {
                Name = "Garfield",
                Id = 1,
                Race = "cat",
                Type = "Yellowcat",
                IsLazy = true
            };

            cat.Eat();
            Console.WriteLine();

            Dog dog2 = new Dog("Aron", "Samoyed");
            Cat cat2 = new Cat("Machor", "cat", "NoRace", true);
            
            Console.ReadLine();
        }
    }
}
