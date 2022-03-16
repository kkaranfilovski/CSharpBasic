using SEDC.Oop.Class05.Exercise2.models;
using System;

namespace SEDC.Oop.Class05.Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dog name:");
            string dogName = Console.ReadLine();

            Console.WriteLine("Enter dog race:");
            string dogRace = Console.ReadLine();

            Console.WriteLine("Enter dog color");
            string dogColor = Console.ReadLine();

            Dog newDog = new Dog(dogName, dogRace, dogColor);

            Console.WriteLine("Enter 1 for the dog to eat. Enter 2 for the dog to play. Enter 3 for the dog to chase its tail");

            string choice = Console.ReadLine();

            if(choice == "1")
            {
                string eat = newDog.Eat();
                Console.WriteLine(eat);
            } else if(choice == "2")
            {
                string play = newDog.Play();
                Console.WriteLine(play);
            } else if(choice == "3")
            {
                string chase = newDog.Chasetail();
                Console.WriteLine(chase);
            } else
            {
                Console.WriteLine("invalid num");
            }
        }
    }
}
