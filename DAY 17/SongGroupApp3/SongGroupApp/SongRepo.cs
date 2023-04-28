using SongGroupApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SongGroupApp
{
    internal class SongRepo

    {

        static List<Song> songs = new List<Song>()
        {

        new Song("Shape Of You","\t\tEdsheeran","Pop",4.8,10000, DateTime.Parse("12-10-2017")),
        new Song("Perfect","\t\t\tEdsheeran","Pop",4.5,12000, DateTime.Parse("04-05-2016")),
        new Song("Something just like this", "Coldplay", "Melody",4.5,105421, 
            DateTime.Parse("05-07-1997")),
        new Song("Mercy", "\t\t\tShawn Mendes", "Jazz",4.8,214500, DateTime.Parse("04-05-2016"))

            };
        public static List<Song> GetAllSongs()
        {
            return songs;

        }

    }
}
