using System;

namespace SEDC.Oop.Class04.Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            SayHello();
            Console.WriteLine(Sum(5, 10));
            Console.WriteLine(WelcomeUser("Kristijan", 26, true));

            Console.ReadLine();
        }

        public static void SayHello()
        {
            Console.WriteLine("hello");
        }

        private static int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }

        internal static string WelcomeUser(string userName, int age, bool shouldBeColored)
        {
            if(shouldBeColored)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }

            string str = string.Empty;

            if(age > 30)
            {
                str = "Welcome mr. " + userName;
            }
            else
            {
                str = "Welcome " + userName;
            }

            return str;
        }
    }
}
