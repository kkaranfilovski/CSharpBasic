using System;

namespace SEDC.Class08.Homework.Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Give the user an option to input numbers
            //After inputing each number ask them if they want to input another with a Y / N question
            //Store all numbers in a QUEUE
            //When the user is done adding numbers print the number in the order that the user entered them from the QUEUE

            Service startApp = new Service();
            startApp.Main();
        }
    }
}
