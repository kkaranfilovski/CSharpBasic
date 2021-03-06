using System;

namespace SEDC.Class03.Homework.StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 2
            //Make a new console application called StudentGroup
            //Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
            //Get a number from the console between 1 and 2 and print the students from that group in the console.

            Console.WriteLine("===== STUDENT GROUP =====");

            string[] studentsG1 = { "Kristijan", "ilija", "Igor", "Stefan", "Krale" };
            string[] studentsG2 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };

            while (true)
            {
                Console.WriteLine("Enter 1 to see the students in G1 or enter 2 to see the students in G2");
                string input = Console.ReadLine();
                bool isValid = int.TryParse(input, out int num);

                if (!isValid || num != 1 && num != 2)
                {
                    Console.WriteLine("invalid input. Please select 1 or 2");
                    continue;
                } else
                {
                    if(num == 1)
                    {
                        Console.WriteLine("The students in G1 are:");
                        foreach(string student in studentsG1)
                        {
                            Console.WriteLine(student);
                        }
                        break;
                    }
                    else if(num == 2)
                    {
                        Console.WriteLine("The students in G2 are:");
                        foreach (string student in studentsG2)
                        {
                            Console.WriteLine(student);
                        }
                        break;
                    }
                }
            }
        }
    }
}
