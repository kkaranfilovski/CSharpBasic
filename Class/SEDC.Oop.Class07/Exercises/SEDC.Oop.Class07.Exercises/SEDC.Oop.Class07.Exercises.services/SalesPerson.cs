using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Exercises.services
{
    public class SalesPerson : Employe
    {
        private double SuccesSaleRevenue { get; set; }

        public SalesPerson(double salerevenue)
            : base(500, Enums.Role.Sales)
        {
            SuccesSaleRevenue = salerevenue;
        }

        public void AddSuccesRevenue(double num)
        {
            SuccesSaleRevenue = num;
        }

        public override double GetSalary()
        {
            if(SuccesSaleRevenue <= 2000)
            {
                return Salary + 500;
            }
            else if(SuccesSaleRevenue > 2000 && SuccesSaleRevenue <= 5000)
            {
                return Salary + 1000;
            }
            else
            {
                return Salary + 1500;
            }
        }
    }
}
