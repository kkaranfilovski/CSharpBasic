using SEDC.Oop.Class09.Exercise.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class09.Exercise.Models
{
    public class Movie
    {
        public string Name { get; set; }
        public Genres Genre { get; set; }
        public int Rating { get; set; }
        public int TicketPrice { get; set; }

        public Movie(string name, Genres genre, int rating)
        {
            Name = name;
            Genre = genre;
            if(rating >=1 && rating <= 5)
            {
                Rating = rating;
            }
            else if(rating < 1)
            {
                throw new Exception("Enter valid rating larger then 1");
            }
            else if(rating > 5)
            {
                throw new Exception("Enter valid rating smaller then 5");
            }

            TicketPrice = rating * 5;
        }
    }
}
