using SEDC.AcademyManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AcademyManagement.Data.Database
{
    public class InMemoryDatabase
    {
        public List<Subject> Subjects { get; set; }
        public List<Admin> Admins { get; set; }
        public List<Trainer> Trainers { get; set; }
        public List<Student> Students { get; set; }
        public InMemoryDatabase()
        {
            InitDatabase();
        }

        private void InitDatabase()
        {
            Subjects = new List<Subject>
            {
                new Subject("HTML", new DateTime(2021, 10, 01), new DateTime(2021, 11, 01), false),
                new Subject("CSS", new DateTime(2021, 11, 02), new DateTime(2021, 12, 01), false),
                new Subject("Basic JS", new DateTime(2021, 12, 02), new DateTime(2022, 01, 11), false),
                new Subject("Advanced JS", new DateTime(2022, 01, 12), new DateTime(2022, 02, 28), false),
                new Subject("Basic C#", new DateTime(2022, 03, 01), new DateTime(2022, 03, 31), false),
                new Subject("Advanced C#", new DateTime(2022, 04, 01), new DateTime(2022, 05, 15), false)
            };

            Admins = new List<Admin>
            {
                new Admin(1, "Administrator", "admin", "admin123")
            };

            Trainers = new List<Trainer>
            {
                new Trainer(1, "Trajan Stevkovski", "trajan", "trajan123"),
                new Trainer(2, "Vlatko Tasevski", "vlatko", "vlatko123")
            };

            Students = new List<Student> // falat predmeti
            {
                new Student(1, "Kristijan Karanfilovski", "krikar", "kiko123"),
                new Student(2, "Ilija Mitev", "ilemit", "ile123"),
                new Student(3, "Igor Nikoloski", "tigremkd", "tigre123"),
                new Student(4, "Radmila Petrusevska", "radpet", "radmila123"),
                new Student(5, "Aneta Stankovska", "anesta", "aneta123")
            };
        }
    }
}
