using System;

namespace SEDC.Oop.class02.Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //int number = 3;
            //long bigNumber = 123456789012345;
            //short shortNumber = 12000;
            //byte smallNumber = 8;

            //double doubleNumber = 12.98313;
            //float singleNumber = 123.125F;

            //string str = "Kristijan Karanfilovski";
            //char singleLetter = 'K';

            //bool isSomethingTrue = true;
            //DateTime currentDate = new DateTime();

            //Console.WriteLine("=========================================");

            //string input = Console.ReadLine();

            //Console.WriteLine(input);

            //int parsedToInt = int.Parse(input);
            //Console.WriteLine(parsedToInt);

            //bool parsedToBoolean = Convert.ToBoolean(input);
            //Console.WriteLine(parsedToBoolean);

            //long parsedToLong = 0;
            //bool isValidInput = long.TryParse(input, out long parsedToLong);
            //Console.WriteLine(isValidInput);
            //Console.WriteLine(parsedToLong);

            Console.WriteLine("==================== BRANCHING ==================");

            //string input = Console.ReadLine();

            //bool isValindInt = int.TryParse(input, out int parsedInput);

            //if (isValindInt)
            //{
            //    Console.WriteLine("The parsed number is " + parsedInput);
            //}
            //else
            //{
            //    Console.WriteLine("ERROR! Not valid input");
            //}

            int firstNumber = 5;
            int secondNumber = 10;
            int thirdNumber = 15;
            int fourthNumber = 20;

            if (firstNumber < secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("the IF statement is TRUE");
            } 
            else if (thirdNumber > fourthNumber || secondNumber > fourthNumber)
            {
                Console.WriteLine("the first else IF statement is TRUE");
            } 
            else if (firstNumber > secondNumber)
            {
                Console.WriteLine("the second IF statement is TRUE");
            } 
            else
            {
                Console.WriteLine("We are in else");
            }

            Console.WriteLine("===========SWITCH===========");

            int someNumber = 3;

            switch (someNumber)
            {
                case 1:
                    break;
                //case 'a':
                //    break;
                case 2:
                    Console.WriteLine("not found");
                    break;
                case 3:
                    Console.WriteLine("found in case 3");
                    break;
                default: Console.WriteLine("nothing");
                    break;
            }

        }
    }
}
