using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class09.Exercise.Models
{
    public class Cinema
    {
        public string Name { get; set; }
        public List<int> Halls { get; set; }
        public List<Movie> Movies { get; set; }

        public Cinema(string name, List<int> halls, List<Movie> movies)
        {
            Name = name;
            Halls = halls;
            Movies = movies;
        }

        public void WatchingMovie(Movie movie)
        {
            Console.WriteLine($"Watching {movie.Name}");
        } 
    }
}
