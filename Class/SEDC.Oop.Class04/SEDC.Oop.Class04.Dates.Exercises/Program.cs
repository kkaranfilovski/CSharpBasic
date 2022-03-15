using System;

namespace SEDC.Oop.Class04.Dates.Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine(date);

            DateTime addDays = date.AddDays(3);
            Console.WriteLine(addDays);

            DateTime addMonth = date.AddMonths(1);
            Console.WriteLine(addMonth);

            DateTime newDate = date.AddDays(3).AddMonths(1);
            Console.WriteLine(newDate);

            DateTime newDate2 = date.AddYears(-1).AddMonths(-2);
            Console.WriteLine(newDate2);

            int month = date.Month;
            Console.WriteLine(month);

            int year = date.Year;
            Console.WriteLine(year);
        }
    }
}
