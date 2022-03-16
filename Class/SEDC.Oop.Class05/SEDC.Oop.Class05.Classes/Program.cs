using SEDC.Oop.Class05.Classes.Models;
using System;


namespace SEDC.Oop.Class05.Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.Age = 26;
            person.Name = "Kristijan";

            person.talk("hello");

            Person person1 = new Person()
            {
                Age = 22,
                Name = "Vlatko"
            };

            person1.talk("Hello students");

            Person person2 = new Person("bob", 23);

            person2.talk("Bob is my name");


            Console.ReadLine();
        }
    }
}
