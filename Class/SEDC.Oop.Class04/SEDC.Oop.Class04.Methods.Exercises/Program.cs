using System;

namespace SEDC.Oop.Class04.Methods.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isActive = true;

            while (isActive)
            {

                Console.WriteLine("Choose '1' for multiply or '2' for subtract");
                string choice = Console.ReadLine();

                if (choice != "1" && choice != "2")
                {
                    Console.WriteLine("Wrong choice");
                    continue;
                }
                else
                {
                    Console.WriteLine("enter num1");
                    string input1 = Console.ReadLine();

                    Console.WriteLine("enter num2");
                    string input2 = Console.ReadLine();

                    bool isValid1 = int.TryParse(input1, out int num1);
                    bool isValid2 = int.TryParse(input2, out int num2);

                    if (!isValid1 || !isValid2)
                    {
                        Console.WriteLine("Invalid numbers");
                        continue;
                    }

                    if (choice == "1")
                    {
                        Console.WriteLine(Multiply(num1, num2));
                        isActive = !isActive;
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine(Subtract(num1, num2));
                        isActive = !isActive;
                    }
                }
            }


        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
