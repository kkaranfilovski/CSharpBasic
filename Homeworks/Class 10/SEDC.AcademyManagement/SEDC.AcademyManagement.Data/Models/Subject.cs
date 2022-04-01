using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AcademyManagement.Data.Models
{
    public class Subject
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }

        public Subject(string name, DateTime dos, DateTime doe, bool isActive)
        {
            Name = name;
            StartDate = dos;
            EndDate = doe;
            IsActive = isActive;
        }
    }
}
