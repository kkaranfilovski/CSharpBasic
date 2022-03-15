using System;

namespace SEDC.Oop.class03.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[4] = 5;

            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[4]);

            string[] names = new string[]
            {
                "Trajan",
                "Vlatko",
                "Stefan",
                "Aneta"
             };

            int[] numbers2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            bool[] booleans = new[] { true, false, true };

            double[] doubles = { 1.1, 1.2, 1.3 };

            int lengthOfArray = names.Length;

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            int indexOfVlatko = Array.IndexOf(names, "Vlatko");

            Console.WriteLine("index is" + indexOfVlatko);
            Console.WriteLine("value is" + names[indexOfVlatko]);

            Array.Resize(ref names, names.Length + 2);

            names[4] = "Bob";
            names[5] = "Jill";

            Array.Sort(names);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("=====FOREACH======");

            foreach (string element in names)
            {
                Console.WriteLine(element);
            }

            foreach (string name in names)
            {
                if (name == "Aneta")
                {
                    continue;
                }

                if (name == "Trajan")
                {
                    break;
                }
                Console.WriteLine(name);
            }

           Console.ReadLine();
        }
    }
}
