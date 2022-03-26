using SEDC.Oop.Class07.Exercises.services.Enums;
using SEDC.Oop.Class07.Exercises.services.Models;
using System;

namespace SEDC.Oop.Class07.Exercises.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====SALES PERSON====");
            SalesPerson kristijan = new SalesPerson("kristijan", "karanfilovski");
            kristijan.AddSuccesRevenue(6000);
            kristijan.GetSalary();
            kristijan.PrintInfo();

            Console.WriteLine("====MANAGER====");
            Manager ilija = new Manager(Department.marketing, "ilija", "mitev");
            ilija.AddBonus(3000);
            ilija.GetSalary();
            ilija.PrintInfo();
            Manager igor = new Manager(Department.finance, "igor", "nikoloski");

            Console.WriteLine("====Contractor====");
            Contractor stefan = new Contractor(40, 100, igor, "stefan", "ivanovski");
            stefan.GetSalary();
            Console.WriteLine("position of manager: " + stefan.CurrentPosition());
            stefan.PrintInfo();

            Contractor aleksandar = new Contractor(40, 5, ilija, "aleskandar", "zivkovic");

            Employe[] company = { kristijan, ilija, igor, stefan, aleksandar };

            Console.WriteLine("====CEO====");
            CEO trajan = new CEO(company, 100, "trajan", "stevkovski");
            trajan.AddSharePrice(50);
            trajan.GetSalary();
            trajan.PrintInfo();
            trajan.PrintEmployes(company);
        }
    }
}
