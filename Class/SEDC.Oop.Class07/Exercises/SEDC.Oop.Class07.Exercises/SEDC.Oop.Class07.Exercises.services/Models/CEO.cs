using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Exercises.services.Models
{
    public class CEO : Employe
    {
        public Employe[] EmployeArray { get; set; }
        public int SharesProperty { get; set; }
        private double SharesPrice { get; set; }

        public CEO(Employe[] employes, int shares, string firstName, string lastName)
            : base(firstName, lastName, Enums.Role.CEO, 1000)
        {
            EmployeArray = employes;
            SharesProperty = shares;
        }
        
        public double AddSharePrice(double num)
        {
            return SharesPrice = num;
        }

        public void PrintEmployes(Employe[] empoloyes)
        {
            Console.WriteLine("EMPLOYES: ");
            foreach (Employe employe in empoloyes)
            {
                Console.WriteLine(employe.FirstName + " " + employe.LastName);
            }

        }

        public override double GetSalary()
        {
            Salary = Salary + (SharesProperty * SharesPrice);
            return Salary;
        }
    }
}
