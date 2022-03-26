using SEDC.Oop.Class08.Exercise2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class08.Exercise2.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person(int id, string name, string lastName, int age, Genre musictype, List<Song> songs)
        {
            Id = id;
            FirstName = name;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = musictype;
            FavoriteSongs = songs;
        }
        public void GetFavSongs()
        {
            if (FavoriteSongs.Count == 0)
            {
                Console.WriteLine("Person hates music");
            }
            else
            {
                foreach (Song value in FavoriteSongs)
                {


                    Console.WriteLine(value.Title);


                }
            }

        }
    }


}
