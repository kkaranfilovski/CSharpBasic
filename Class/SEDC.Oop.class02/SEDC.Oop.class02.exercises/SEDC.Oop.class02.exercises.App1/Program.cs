using System;

namespace SEDC.Oop.class02.exercises.App1
{
    class Program
    {
        static void Main(string[] args)
        {

            // exercise 1

            double firstDouble = 5.3236566565;
            double secondDouble = 3.596965564;

            double resultDouble = firstDouble / secondDouble;

            int firstInt = 8656;
            int secondInt = 2323;

            int resultInt = firstInt / secondInt;

            Console.WriteLine(resultDouble);
            Console.WriteLine(resultInt);
            Console.WriteLine(resultDouble == resultInt);

            // exercise 2

            string name = "Kristijan ";
            string lastName = "Karanfilovski";

            string fullName = name + lastName;

            string stringOne = "9";
            string stringTwo = "3";

            string resultString = stringOne + stringTwo;

            Console.WriteLine(fullName);
            Console.WriteLine(resultString);

            //exercise 3

            int integerThree = 10;
            string stringThree = "Kiko";

            string resultThree = integerThree + stringThree;

            Console.WriteLine(resultThree);


            // exercise 4

            int n = 102;
            int m = 5;
            int sms = n / m;

            Console.WriteLine(sms);
        }
    }
}
