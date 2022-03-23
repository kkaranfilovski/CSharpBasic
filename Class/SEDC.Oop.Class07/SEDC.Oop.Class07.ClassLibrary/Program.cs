using SEDC.Oop.Class07.Services;
using System;

namespace SEDC.Oop.Class07.ClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EmployeService employeService = new EmployeService();
            employeService.CreateObjectAndWriteInConsole();

            Console.ReadLine();
        }
    }
}
