using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class05.Exercise3.models
{
    public class Student
    {
        public string Name { get; set; }
        public string Academy { get; set; }

        public int Group { get; set; }

        public Student(string name, string academy, int group)
        {
            Name = name;
            Academy = academy;
            Group = group;
        }
    }
}
