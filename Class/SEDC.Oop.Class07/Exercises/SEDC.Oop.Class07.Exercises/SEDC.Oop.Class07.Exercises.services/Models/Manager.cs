using SEDC.Oop.Class07.Exercises.services.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Exercises.services.Models
{
    public class Manager : Employe
    {
        private double Bonus { get; set; }
        public Department Department { get; set; }

        public Manager(Department department, string firstName, string lastName)
            : base(firstName, lastName, Enums.Role.Manager, 1000 )
        {
            Department = department;
        }
        public double AddBonus(double num)
        {
            return Bonus += num;
        }

        public override double GetSalary()
        {
            return Salary += Bonus;
        }
    }



}
