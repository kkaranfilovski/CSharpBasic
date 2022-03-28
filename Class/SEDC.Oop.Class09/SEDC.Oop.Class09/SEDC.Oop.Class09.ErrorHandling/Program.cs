using SEDC.Oop.Class09.ErrorHandling.Models;
using System;

namespace SEDC.Oop.Class09.ErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {


            //try
            //{
            //    Console.WriteLine("Number example");
            //    Console.WriteLine("Enter a number");
            //    string input = Console.ReadLine();
            //    int number = int.Parse(input);
            //    Console.WriteLine(number);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("We are in format exeption");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("We are in argument exeption");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("We are in overflow exeption");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("I will always be executed!");
            //}

            //Console.WriteLine("Enter the letter a or b");

            //try
            //{
            //    string inputStr = Console.ReadLine();
            //    if (inputStr == "a" || inputStr == "b")
            //    {
            //        Console.WriteLine("Congrats. You entered A or B");
            //    }
            //    else
            //    {
            //        throw new Exception("That is not a or b! Sorry");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}

            //try
            //{
            //    Console.WriteLine("enter number 2");
            //    string consoleInput = Console.ReadLine();
            //    int a = ParseNumber(consoleInput);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}

            HumanServiceMainMethod();
            HumanServiceMainMethod2();

            Console.ReadLine();
        }

        public static int ParseNumber(string input)
        {
            try
            {
                return int.Parse(input);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void HumanServiceMainMethod()
        {
            HumanService service = new HumanService();

            foreach (Human human in service.Humans)
            {
                try
                {
                service.PrintHumanSkills(human);
                }
                catch(Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }

            foreach (Human human in service.Humans)
            {
                try
                {
                    service.GetFirstHumanSkill(human);
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
        }

        public static void HumanServiceMainMethod2()
        {
            HumanService service = new HumanService();

            foreach (Human human in service.Humans)
            {
                try
                {
                    service.PrintHumanSkills1(human);
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
        }
    }
}
