using SEDC.Oop.Class06.Task3.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class06.Task3.services
{
    class UserServices
    {
        public User[] Login(User[] users)
        {
            ATM options = new ATM();

            while (true)
            {
                Console.WriteLine("Enter your card number");
                string cardNum = Console.ReadLine();
                bool isFound = false;

                foreach (User user in users)
                {
                    if (cardNum == user.CardNumber)
                    {
                        isFound = true;
                        while (true)
                        {
                            Console.WriteLine("Enter your pin");
                            string input = Console.ReadLine();
                            bool isValid = int.TryParse(input, out int parsedPin);

                            if (!isValid)
                            {
                                Console.WriteLine("Invalid pin format. Try again!");
                                continue;
                            }
                            else if (parsedPin == user.Pin)
                            {
                                options.Options(user);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid pin. Try again");
                                continue;
                            }
                        }
                    }
                }
                if (!isFound)
                {
                    Console.WriteLine("Error. Enter valid credit card number");
                    continue;
                }

                return users;

            }
        }
        public User[] Register(User[] users)
        {
            User registeredUser = RegisterUser(users);
            users = AddNewUser(registeredUser, users);

            Console.WriteLine("Succesfull registration. You can login to deposit cash on your account.");
            foreach (User user in users)
            {
                Console.WriteLine(user.CardNumber);
            }

            return users;
        }
        private User RegisterUser(User[] users)
        {
            string name = ValidateUserName();
            string cardNum = ValidateCardNum(users);
            int pin = ValidatePin();
            User newUser = new User(name, cardNum, pin, 0);
            return newUser;
        }
        private string ValidateUserName()
        {
            while (true)
            {
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();

                if (name.Length < 5)
                {
                    Console.WriteLine("Your name must have at least 5 characters");
                    continue;
                }
                return name;
            }
        }
        private string ValidateCardNum(User[] users)
        {
            while (true)
            {
                bool isFound = false;
                Console.WriteLine("Enter your card number");
                string cardNumber = Console.ReadLine();
                if (cardNumber.Length < 3)
                {
                    Console.WriteLine("Invalid card number");
                    continue;
                }

                foreach (User user in users)
                {
                    if (cardNumber == user.CardNumber)
                    {
                        Console.WriteLine("There is already a user with that card number");
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
                    return cardNumber;
                }
            }
        }
        private int ValidatePin()
        {
            while (true)
            {
                Console.WriteLine("Enter your pin:");
                string pin = Console.ReadLine();
                bool isValid = int.TryParse(pin, out int parsedPin);

                if (!isValid)
                {
                    Console.WriteLine("Invalid format. Your pin can contain only numbers.");
                    continue;
                }
                else if(parsedPin < 1000)
                {
                    Console.WriteLine("Your pin must contain at least 4 numbers. Example: 1234");
                    continue;
                }
                else
                {
                    return parsedPin;
                }
            }
        }
        private User[] AddNewUser(User user, User[] users)
        {
            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = user;
            return users;
        }
    }
}
