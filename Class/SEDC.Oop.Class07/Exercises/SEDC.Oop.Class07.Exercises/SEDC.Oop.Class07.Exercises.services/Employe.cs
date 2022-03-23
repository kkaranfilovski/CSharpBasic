using SEDC.Oop.Class07.Exercises.services.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Exercises.services
{
    public class Employe
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MyProperty { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} {GetSalary()}");
        }

        public Employe()
        {

        }

        public Employe(double salary, Role role)
        {
            Salary = salary;
            Role = role;
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
