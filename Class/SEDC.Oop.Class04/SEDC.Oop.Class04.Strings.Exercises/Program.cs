using System;

namespace SEDC.Oop.Class04.Strings.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {


            bool isActive = true;

            while (isActive)
            {
                Console.WriteLine("enter number");
                string input = Console.ReadLine();

                bool isValid = int.TryParse(input, out int num);

                if (!isValid)
                {
                    Console.WriteLine("invalid number");
                    continue;
                }
                else
                {
                    string result = Substrings(num);
                    Console.WriteLine(result);
                    isActive = !isActive;
                }
            }
        }

        static string Substrings(int number)
        {
            string greeting = "Hello from SEDC Codeacademy 2021";

            if (number < 0 || number > greeting.Length)
            {
                return "error";

            }
            else
            {
                string subStringedGreeting = greeting.Substring(0, number);

                return subStringedGreeting;
            }
        }
    }
}
