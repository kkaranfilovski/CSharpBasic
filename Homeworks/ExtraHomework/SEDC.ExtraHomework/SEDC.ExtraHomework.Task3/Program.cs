using System;

namespace SEDC.ExtraHomework.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 3:
            //Create a two function that calculates the amount of numeric digits and vowels(samoglaski) that a text string contains. 
            //It will accept one parameter parameter: the string that we want to search,

            //Function 1 should return the number of digits,
            //Function 2 should return the number of vowels.

            string name = "KrIstiJaN 26.06.1995";

            int vowels = NumberOfVowels(name);
            int digits = NumberOfDigits(name);
            Console.WriteLine(vowels);
            Console.WriteLine(digits);
        }

        static int NumberOfVowels(string str)
        {
            int vowels = 0;

            string strToLower = str.ToLower();

            for(int i = 0; i < strToLower.Length; i++)
            {
                if(strToLower[i] == 'a' || strToLower[i] == 'e' || strToLower[i] == 'i' || strToLower[i] == 'o' || strToLower[i] == 'u')
                {
                    vowels++;
                }
            }

            return vowels;
        }

        static int NumberOfDigits(string str)
        {
            int digits = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if(Char.IsDigit(str[i]))
                {
                    digits++;
                }
            }
            return digits;
        }
    }
}
