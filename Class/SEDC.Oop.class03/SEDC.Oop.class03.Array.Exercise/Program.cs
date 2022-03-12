using System;

namespace SEDC.Oop.class03.Arrays.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("=========== TASK 1 ==========");

            //string[] words = { "Kiko", "Ilija", "Trajan", "Igor", "Vlatko" };

            //double[] doubles = { 1.1, 1.2, 1.3 };

            //char[] characters = { 'a', 'b', 'c', 'd', 'e' };

            //bool[] booleans = { true, false, true, false, true };

            //int[] arr1 = new int [2];
            //int[] arr2 = { 3, 4 };

            //int[] array = { arr1 };

            //Console.WriteLine("=========== TASK 2 ==========");

            //int[] numbers = new int[5];
            
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    string input = Console.ReadLine();
            //    bool isValid = int.TryParse(input, out int number);

            //    if (!isValid)
            //    {
            //        continue;
            //    }

            //    numbers[i] = number;
            //}

            Console.WriteLine("=========== TASK 3 ==========");

            string[] names = new string[0];

            Console.WriteLine("Enter a name:");
            string input = Console.ReadLine();

            Array.Resize(ref names, names.Length + 1);
            for(int i = 0; i < names.Length; i++)
            {
                names[i] = input;
            }

            Console.WriteLine("Do you want to enter another name: Y/N");
            string choice = Console.ReadLine();

            while (true)
            {
                if(choice == "y")
                {
                    Console.WriteLine("Enter a name:");
                    string input1 = Console.ReadLine();

                    Array.Resize(ref names, names.Length + 1);
                    for (int i = 0; i < names.Length; i++)
                    {
                        names[i] = input;
                    }
                } else if(choice == "n")
                {
                    break;
                }
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
