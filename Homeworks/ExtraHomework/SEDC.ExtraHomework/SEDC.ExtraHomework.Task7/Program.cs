using System;

namespace SEDC.ExtraHomework.Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 7:
            //Create a function that calculates the result of raising an integer to another integer(eg 5 raised to 3 = 53 = 5 × 5 × 5 = 125).

            double result = Exponent(5, 3);
            Console.WriteLine(result);
        }

        static double Exponent (double numX, double numY)
        {
            double result = Math.Pow(numX, numY);
            return result;
        }
    }
}
