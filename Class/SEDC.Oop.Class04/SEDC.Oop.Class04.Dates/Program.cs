using System;

namespace SEDC.Oop.Class04.Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime();

            Console.WriteLine(date);

            DateTime customDate = new DateTime(1995, 6, 26);

            Console.WriteLine(customDate);

            string date1 = "12.15.2012";
            string date2 = "12/15/2012";
            string date3 = "12/15/12";
            string date4 = "dec.15.12";
            string date5 = "12-15-2012";

            DateTime convertedDate = DateTime.Parse(date4);
            Console.WriteLine(convertedDate);

            DateTime currentDate = DateTime.Today;
            Console.WriteLine(currentDate);

            DateTime currentDateAndTime = DateTime.Now;
            Console.WriteLine(currentDateAndTime);

            Console.WriteLine("===============");

            DateTime currentDate1 = currentDateAndTime.Date;
            Console.WriteLine(currentDate1);

            DateTime addedDays = currentDateAndTime.AddDays(5);
            DateTime removeDays = currentDateAndTime.AddDays(-10);
            DateTime addedMonth = currentDateAndTime.AddMonths(5);
            DateTime addedYear = currentDateAndTime.AddYears(3);

            int year = currentDateAndTime.Year;
            int day = currentDateAndTime.Day;
            int month = currentDateAndTime.Month;

            Console.WriteLine("===============");

            string dateFormat1 = currentDateAndTime.ToString("MM/dd/yyyy");
            string dateformat2 = currentDateAndTime.ToString("dd/MM/yyyy");
            string dateformat3 = string.Format("Today is {0:dd/MM/yyyy}", currentDateAndTime);
            Console.WriteLine(dateFormat1);
            Console.WriteLine(dateformat2);
            Console.WriteLine(dateformat3);

        }
    }
}
