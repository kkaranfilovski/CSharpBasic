using SEDC.Oop.Class06.Task3.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class06.Task3.services
{
    public class Balance
    {
        public void CheckBalance(User user)
        {
            Console.WriteLine($"Your balance is {user.Balance}");
        }
    }
}
