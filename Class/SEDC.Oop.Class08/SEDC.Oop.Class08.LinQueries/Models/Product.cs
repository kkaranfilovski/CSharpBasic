﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class08.LinQueries.Models
{
    class Product
    {
        public Product()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }
    }
}
