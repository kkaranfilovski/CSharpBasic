using System;

namespace SEDC.Oop.class03.Arrays.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("=========== TASK 1 ==========");

            //string[] words = { "Kiko", "Ilija", "Trajan", "Igor", "Vlatko" };

            //double[] doubles = { 1.1, 1.2, 1.3, 1.4, 1.5 };

            //char[] characters = { 'a', 'b', 'c', 'd', 'e' };

            //bool[] booleans = { true, false, true, false, true };

            //int[] arr1 = { 1, 2 };
            //int[] arr2 = { 3, 4 };
            //int[] arr3 = { 5, 6 };
            //int[] arr4 = { 7, 8 };
            //int[] arr5 = { 9, 10 };

            //int[][] array = { arr1, arr2, arr3, arr4, arr5 };


            //Console.WriteLine("=========== TASK 2 ==========");

            //int[] numbers = new int[5];
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{

            //    Console.WriteLine("enter number" + (i + 1));
            //    string input = Console.ReadLine();
            //    bool isValid = int.TryParse(input, out int number);

            //    if(isValid)
            //    {
            //        numbers[i] = number;
            //        sum += numbers[i];
            //    } else
            //    {
            //        Console.WriteLine("invalid number.");
            //    }         
            //}

            //Console.WriteLine(sum);


            Console.WriteLine("=========== TASK 3 ==========");

            string[] names = new string[0];
            int counter = 0;

            while (true)
            {
                Console.WriteLine("Enter a name:");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("invalid name");
                    continue;
                }
                else
                {
                    Array.Resize(ref names, names.Length + 1);
                    names[counter] = input;
                    counter++;
                    break;
                }
            }


            while (true)
            {
                Console.WriteLine("Do you want to enter another name? Y / N");
                string choice = Console.ReadLine();

                if (choice.ToLower() == "y")
                {
                    Console.WriteLine("Enter a name:");
                    string anotherName = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(anotherName))
                    {
                        Console.WriteLine("invalid name. Try again");
                        continue;
                    }
                    else
                    {
                        Array.Resize(ref names, names.Length + 1);
                        names[counter] = anotherName;
                        counter++;
                    }
                }
                else if (choice.ToLower() == "n")
                {
                    Console.WriteLine("thank you for using the app. Entered names:");
                    foreach (string name in names)
                    {
                        Console.WriteLine(name);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("invalid choice. Choose 'Y' or 'N'");
                    continue;
                }
            }
        }
    }
}
