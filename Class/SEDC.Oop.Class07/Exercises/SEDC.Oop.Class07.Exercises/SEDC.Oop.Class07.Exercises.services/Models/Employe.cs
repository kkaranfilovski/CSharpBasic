using SEDC.Oop.Class07.Exercises.services.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Exercises.services.Models
{
    public class Employe
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Role: {Role} First name: {FirstName}, Last Name: {LastName}, Salary: {Salary}");
        }

        public Employe(string firstName, string lastName, Role role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }
        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
