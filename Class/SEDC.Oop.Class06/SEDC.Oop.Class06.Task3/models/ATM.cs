using SEDC.Oop.Class06.Task3.services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class06.Task3.models
{
    class ATM
    {
        public User[] Users { get; set; }
        public void Main()
        {
            User[] users = new User[] {
                new User("kristijan", "1111", 1234, 1000),
                new User("ilija", "2222", 5555, 500),
                new User("petko", "3333", 6666, 200)
            };

            StartMenu(users);
        }

        private void StartMenu(User[] users)
        {
            UserServices userServices = new UserServices();
            while (true)
            {
                Console.WriteLine("Welcome to the ATM");
                Console.WriteLine("Choose one ot the following options:");

                Console.WriteLine("1. Login with your card");
                Console.WriteLine("2. Register new card");
                Console.WriteLine("3. Exit");

                string selection = Console.ReadLine();

                if (selection == "1")
                {
                    users = userServices.Login(users);
                }
                else if (selection == "2")
                {
                    users = userServices.Register(users);
                }
                else if (selection == "3")
                {
                    Console.WriteLine("Thanks for using our ATM!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                    continue;
                }
            }
        }
        public void Options(User user)
        {
            Balance showBalance = new Balance();
            Transactions transaction = new Transactions();

            while (true)
            {
                Console.WriteLine($"Welcome {user.Name}");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Cash Withdrawal");
                Console.WriteLine("3. Cash Deposit");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    showBalance.CheckBalance(user);
                }
                else if (choice == "2")
                {
                    transaction.Withdraw(user);
                }
                else if (choice == "3")
                {
                    transaction.Deposit(user);
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                    continue;
                }
                Console.WriteLine("Do you want to continue using the app ? Enter '1' to continue or press any other key to exit..");
                string selection = Console.ReadLine();

                if(selection == "1")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Goodbye. See you soon");
                    break;
                }
            }
        }
    }
}
