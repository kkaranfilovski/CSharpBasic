using System;

namespace SEDC.Oop.class02.exercises.exerc5
{
    class Program
    {
        static void Main(string[] args)
        {
            //double branches = 12;
            //double apples = 8;
            //double basket = 5;
            //double trees = 1;

            //double result = trees * branches * apples / basket;

            //Console.WriteLine(result);

            // exercise 6

            //       string inputOne = Console.ReadLine();
            //        string inputTwo = Console.ReadLine();

            //       bool isValindIntOne = int.TryParse(inputOne, out int parsedInputOne);
            //        bool isValindIntTwo = int.TryParse(inputTwo, out int parsedInputTwo);

            //        if (parsedInputOne > parsedInputTwo)
            //        {
            //            Console.WriteLine(parsedInputOne + " is larger");
            //            if (parsedInputOne % 2 == 0)
            //            {
            //                Console.WriteLine(parsedInputOne + " is even");
            //           }
            //            else
            //           {
            //                Console.WriteLine(parsedInputOne + " is odd");
            //              //}

            //         }
            //         else
            //         {
            //                onsole.WriteLine(parsedInputTwo + " is larger");
            //                if (parsedInputTwo % 2 == 0)
            //                {
            //                    Console.WriteLine(parsedInputTwo + " is even");
            //                  else
            //                {
            //                  Console.WriteLine(parsedInputTwo + " is odd");
            //               }
            //   }
            //}

            // exerise 7

            Console.WriteLine("enter a number from 1 to 3");
            string inputOne = Console.ReadLine();
            bool isValindIntOne = int.TryParse(inputOne, out int parsedInputOne);

            switch (parsedInputOne)
            {
                case 1: Console.WriteLine("You get a new car");
                    break;
                case 2: Console.WriteLine("You get a new plane");
                    break;
                case 3: Console.WriteLine("You get a new bike");
                    break;
                default: Console.WriteLine("enter valid number");
                    break;

            }
        }
    }
}

