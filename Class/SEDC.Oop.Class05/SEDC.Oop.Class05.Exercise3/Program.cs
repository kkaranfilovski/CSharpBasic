using SEDC.Oop.Class05.Exercise3.models;
using System;

namespace SEDC.Oop.Class05.Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Student student1 = new Student("Kristijan", "SEDC", 3);
            Student student2 = new Student("Ilija", "SEDC", 3);
            Student student3 = new Student("Stefan", "SEDC", 3);
            Student student4 = new Student("Aneta", "SEDC", 3);
            Student student5 = new Student("Timotej", "SEDC", 3);

            Student[] studentsArray = { student1, student2, student3, student4, student5 };

            Console.WriteLine("Enter name:");
            string input = Console.ReadLine();

            foreach(Student student in studentsArray)
            {
                if(student.Name == input)
                {
                    Console.WriteLine($"Student by that name exists {input}");
                    break;
                }
            }



        }
    }
}
