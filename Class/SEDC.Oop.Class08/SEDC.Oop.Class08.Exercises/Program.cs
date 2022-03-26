using System;
using System.Collections.Generic;

namespace SEDC.Oop.Class08.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> phoneBook = new Dictionary<string, int> 
            {
                {"kristijan", 072210670 },
                {"ilija", 075222222 },
                {"vlatko", 072323323 },
                {"trajan", 078569123 },
                {"igor", 071111111 }
            };

            Console.WriteLine("Enter a name:");
            string input = Console.ReadLine();
            bool isFound = false;

            Console.WriteLine("============TryGetValue============");
            
            bool isFoundNum = phoneBook.TryGetValue(input, out int value);
            if (isFoundNum)
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("No such contact");
            }

            Console.WriteLine("============ForEach============");

            foreach (KeyValuePair<string, int> keyValue in phoneBook)
            {
                if(input == keyValue.Key)
                {
                    Console.WriteLine(keyValue.Value);
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("No such contact");
            }

        }
    }
}
