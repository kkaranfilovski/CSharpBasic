using SEDC.Oop.Class08.Exercise2.Enums;
using SEDC.Oop.Class08.Exercise2.Models;
using System;
using System.Collections.Generic;

namespace SEDC.Oop.Class08.Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            Song song1 = new Song("SongTitle1", 3, Genre.Techo);

            List<Song> songs = new List<Song>
            {
                song1
            };

            List<Song> noSongs = new List<Song>();


            Person kristijan = new Person(1, "kristijan", "karanfilovski", 26, Genre.Techo, songs);

            Person trajan = new Person(2, "trajan", "stevkovski", 33, Genre.Hip_Hop, noSongs);

            kristijan.GetFavSongs();
            trajan.GetFavSongs();


        }
    }
}
