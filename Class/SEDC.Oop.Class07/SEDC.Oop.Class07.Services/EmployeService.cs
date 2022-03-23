using SEDC.Oop.Class07.Models;
using SEDC.Oop.Class07.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Services
{
    public class EmployeService
    {
        public void CreateObjectAndWriteInConsole()
        {
            Employee employe = new Employee() { Id = 1, Name = "Bob", Role = Role.Guest };
            Console.WriteLine($"Employee {employe.Name} is created.");
        }
    }
}
