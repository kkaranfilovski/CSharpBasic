using SEDC.Oop.Class09.Exercise.Models;
using System;
using System.Collections.Generic;

namespace SEDC.Oop.Class09.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();

            try
            {
                movies = new List<Movie>
                {
                new Movie("movie1", Enums.Genres.Comedy, 3),
                new Movie("movie2", Enums.Genres.Horror, 1),
                new Movie("movie3", Enums.Genres.Comedy, 88),
                new Movie("movie4", Enums.Genres.Comedy, 10),
                new Movie("movie5", Enums.Genres.Comedy, 4),
                new Movie("movie6", Enums.Genres.Comedy, -5),
                new Movie("movie7", Enums.Genres.Comedy, 9),
                new Movie("movie8", Enums.Genres.Comedy, 5),
                new Movie("movie9", Enums.Genres.Comedy, 5),
                new Movie("movie10", Enums.Genres.Comedy, 5),
                };

                foreach (Movie movie in movies)
                {
                    Console.WriteLine(movie.Name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

