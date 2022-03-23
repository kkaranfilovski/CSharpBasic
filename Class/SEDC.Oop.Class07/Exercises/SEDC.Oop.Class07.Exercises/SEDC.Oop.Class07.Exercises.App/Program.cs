using SEDC.Oop.Class07.Exercises.services;
using System;

namespace SEDC.Oop.Class07.Exercises.App
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesPerson kiko = new SalesPerson(10);
            kiko.AddSuccesRevenue(9000);
            double salary = kiko.GetSalary();
            Console.WriteLine(salary);

            Manager trajan = new Manager();
            trajan.AddBonus(5000);
            double trajanSalary = trajan.GetSalary();
            Console.WriteLine(trajanSalary);
        }
    }
}
