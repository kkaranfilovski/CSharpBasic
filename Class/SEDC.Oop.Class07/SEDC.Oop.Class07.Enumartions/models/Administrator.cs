using SEDC.Oop.Class07.Enumartions.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class07.Enumartions.models
{
    public class Administrator
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public Roles Role { get; set; }

        public Administrator(string name)
        {
            Id = 1;
            Name = name;
        }
    }
}
