using SEDC.Oop.Class06.Task2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class06.Task2.Services
{
    public class UserServices
    {
        public User[] Login(User[] users)
        {
            Console.WriteLine("Enter your username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();
            bool isFound = false;

            foreach (User user in users)
            {
                if (userName == user.UserName && password == user.Password)
                {
                    isFound = true;
                    Console.WriteLine($"Welcome {user.UserName.ToUpper()}. Here are your messages:");
                    foreach (string message in user.Messages)
                    {
                        Console.WriteLine(message);
                    }
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("Username or password does not match!");
            }
            return users;
        }

        public User[] Register(User[] users)
        {
            User registeredUser = RegisterUser(users);
            users = AddNewUser(registeredUser, users);

            Console.WriteLine("Registration complete! Users:");
            foreach (User user in users)
            {
                Console.WriteLine($"{user.Id}. {user.UserName}");
            }
            return users;
        }
        private User RegisterUser(User[] users)
        {
            while (true)
            {
                bool isFound = false;
                Console.WriteLine("Enter username");
                string userName = Console.ReadLine();

                if (userName.Length < 5)
                {
                    Console.WriteLine("Username must contain at least five characters");
                    continue;
                }

                foreach (User user in users)
                {
                    if (user.UserName == userName)
                    {
                        Console.WriteLine("There is already user with that username. Try another");
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                {
                    continue;
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("Enter id:");
                        string id = Console.ReadLine();

                        bool isValid = int.TryParse(id, out int parsedId);
                        if (!isValid)
                        {
                            Console.WriteLine("Enter valid ID only using numbers. Ex: 123");
                            continue;
                        }

                        Console.WriteLine("Enter password");
                        string password = Console.ReadLine();

                        User newUser = new User(parsedId, userName, password, new string[] { });
                        return newUser;
                    }
                }
            }

        }
        private User[] AddNewUser(User user, User[] users)
        {
            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = user;
            return users;
        }
        public void Main(User[] users, UserServices userServices)
        {
            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        users = userServices.Login(users);
                        break;
                    case "2":
                        users = userServices.Register(users);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again");
                        continue;
                }

                Console.WriteLine("Press 1 to continue using the app or any other key to exit.");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Thanks for using the app");
                    break;
                }
            }
        }
    }
}
