using SEDC.Oop.Class06.Task3.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class06.Task3.services
{
    public class Transactions
    {
        public void Withdraw(User user)
        {
            while (true)
            {
                if(user.Balance == 0)
                {
                    Console.WriteLine("You dont have any money to withdraw");
                    break;
                }
                Console.WriteLine("Enter the ammount you want to withdraw:");
                string input = Console.ReadLine();
                bool isValid = int.TryParse(input, out int withdrawAmmount);

                if (!isValid || withdrawAmmount <= 0)
                {
                    Console.WriteLine("Enter valid ammount!");
                    continue;
                }
                else
                {
                    if (user.Balance < withdrawAmmount)
                    {
                        Console.WriteLine($"You have insuficient funds. Your balance is {user.Balance}.");
                        continue;
                    }
                    else
                    {
                        user.Balance = user.Balance - withdrawAmmount;
                        Console.WriteLine($"You withdrew {withdrawAmmount}. You have {user.Balance} left on your account.");
                        break;
                    }
                }
            }
        }

        public void Deposit(User user)
        {
            while (true)
            {
                Console.WriteLine("Enter the ammount you want to deposit:");
                string input = Console.ReadLine();
                bool isValid = int.TryParse(input, out int depositAmmount);

                if (!isValid || depositAmmount <= 0)
                {
                    Console.WriteLine("Enter valid ammount!");
                    continue;
                }
                else
                {
                    user.Balance = user.Balance + depositAmmount;
                    Console.WriteLine($"YOu deposited {depositAmmount}. You have {user.Balance} on your account.");
                    break;
                }
            }
        }
    }
}
