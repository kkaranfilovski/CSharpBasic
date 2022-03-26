using SEDC.Oop.Class07.Exercises.services.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Exercises.services.Models
{
    public class Contractor : Employe
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(double hours, int payPerHour, Manager responsible, string firstName, string lastName)
            : base(firstName, lastName, Role.Contractor, 500)
        {
            WorkHours = hours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }

        public Department CurrentPosition()
        {
            return Responsible.Department;
        }
    }

    
}
