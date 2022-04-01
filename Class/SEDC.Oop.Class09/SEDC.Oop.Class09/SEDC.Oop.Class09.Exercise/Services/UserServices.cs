using SEDC.Oop.Class09.Exercise.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class09.Exercise.Services
{
    public class UserServices
    {
        public Cinema ChooseCinema(List<Cinema> cinemas)
        {
            while (true)
            {
            Console.WriteLine("Choose cinema by the number:");
            int counter = 1;
            foreach (Cinema cinema in cinemas)
            {
                Console.WriteLine($"{counter}. {cinema.Name}");
                counter++;
            }
            try
            {
                string input = Console.ReadLine();
                int parsedInput = int.Parse(input);
                return cinemas[parsedInput - 1];
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            }
        }
    }
}
