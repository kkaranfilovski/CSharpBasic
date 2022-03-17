using System;

namespace SEDC.ExtraHomework.Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 6:
            //Create a function to find the number of times a substring appears in a given string.

            string name = "SEDC SEDCc SEDCcC SEDCcCc SEDCcCcC";

            int result = Occurances(name, "c");

            Console.WriteLine(result);
        }

        static int Occurances (string str, string substr)
        {
            int count = str.ToLower().Split(substr).Length - 1;

            return count;
        }
    }
}
