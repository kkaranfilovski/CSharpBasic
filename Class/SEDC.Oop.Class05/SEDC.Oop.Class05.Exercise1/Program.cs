using SEDC.Oop.Class05.Exercise1.NewFolder;
using System;

namespace SEDC.Oop.Class05.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter name:");
            string nameInput = Console.ReadLine();

            Console.WriteLine("Enter lastname");
            string lastNameInput = Console.ReadLine();

            Console.WriteLine("enter age");
            string ageInput = Console.ReadLine();
            bool isValid = int.TryParse(ageInput, out int age);

            Human human = new Human(nameInput, lastNameInput, age);

            string result = human.GetPersonStats();

            Console.WriteLine(result);
        }
    }
}
