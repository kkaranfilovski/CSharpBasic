using SEDC.AcademyManagement.Data.BaseModels;
using SEDC.AcademyManagement.Data.Enummerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AcademyManagement.Data.Models
{
    public class Student : User
    {
        public Subject CurrentSubject { get; set; }
        public List<Subject> FinishedSubjects { get; set; }
        public Dictionary<Subject, int> Grades { get; set; }

        public Student(int id, string fullName, string userName, string password)
            :base(id, fullName, userName, password, Roles.Student)
        {
            // logika za predmeti..
        }

    }
}
