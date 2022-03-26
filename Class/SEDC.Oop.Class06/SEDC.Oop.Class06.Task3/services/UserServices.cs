using SEDC.Oop.Class06.Task3.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class06.Task3.services
{
    class UserServices
    {
        ATM options = new ATM();
        Validations validation = new Validations();
        public User[] Login(User[] users)
        {
            while (true)
            {
                long cardNum = validation.ValidateCardNum();
                bool isFound = false;

                foreach (User user in users)
                {
                    if (cardNum == user.CardNumber)
                    {
                        isFound = true;
                        while (true)
                        {
                            int pin = validation.ValidatePin();
                            if (pin == user.Pin)
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
            User registeredUser = RegisterNewUser(users);
            users = AddNewUser(registeredUser, users);

            Console.WriteLine("Succesfull registration. You can login to deposit cash on your account.");
            Console.WriteLine();
            return users;
        }
        private User RegisterNewUser(User[] users)
        {
            string name = validation.ValidateUserName();
            while (true)
            {
                long cardNum = validation.ValidateCardNum();
                bool isFound = false;
                foreach (User user in users)
                {
                    if (user.CardNumber == cardNum)
                    {
                        Console.WriteLine("there is already user with that card number!");
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
                    int pin = validation.ValidatePin();
                    User newUser = new User(name, cardNum, pin, 0);
                    return newUser;
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
