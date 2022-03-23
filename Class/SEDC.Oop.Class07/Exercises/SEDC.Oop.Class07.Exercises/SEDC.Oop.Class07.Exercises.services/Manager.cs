using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Exercises.services
{
    public class Manager : Employe
    {
        private double Bonus { get; set; }

        public Manager()
            : base(1000, Enums.Role.Manager)
        {

        }
        public void AddBonus(double num)
        {
            Bonus = Bonus + num;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }



}
