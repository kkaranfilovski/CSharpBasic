using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class06.Task3.services
{
    class Validations
    {
        public string ValidateUserName()
        {
            while (true)
            {
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();

                if (name.Length < 4)
                {
                    Console.WriteLine("Your name must have at least 4 characters");
                    continue;
                }

                return name;
            }
        }
        public long ValidateCardNum()
        {
            while (true)
            {
                Console.WriteLine("Enter your card number in the following format: ****-****-****-****");
                string cardNumber = Console.ReadLine();
                string modifiedCardNum = cardNumber.Replace("-", "");

                bool isValid = long.TryParse(modifiedCardNum, out long parsedCardNum);

                if (!isValid)
                {
                    Console.WriteLine("Invalid card number");
                    continue;
                }
                else if (parsedCardNum.ToString().Length != 16)
                {
                    Console.WriteLine("Your credit card must contain 16 numbers!");
                    continue;
                }
                else
                {
                    return parsedCardNum;
                }
            }
        }
        public int ValidatePin()
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
                else if (parsedPin < 1000)
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
    }
}
