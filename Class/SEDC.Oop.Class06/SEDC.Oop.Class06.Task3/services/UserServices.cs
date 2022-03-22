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
            return users;
        }
    }
}
