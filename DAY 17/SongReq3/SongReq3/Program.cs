using System;

using System.Collections.Generic;

namespace SongReq3
{

    class MainClass

    {

        static void Main()

        {

            // create some sample songs

            Song s1 = new Song { Name = "Shape Of You", Artist = "Edsheeran", SongType = "Pop", Rating = 4.8, NumberOfDownloads = 10000, DateDownloaded = DateTime.Parse("12-10-2017") };

            Song s2 = new Song { Name = "Perfect", Artist = "Edsheeran", SongType = "Pop", Rating = 4.5, NumberOfDownloads = 12000, DateDownloaded = DateTime.Parse("04-05-2016") };

            Song s3 = new Song { Name = "Something just like this", Artist = "Coldplay", SongType = "Melody", Rating = 4.5, NumberOfDownloads = 105421, DateDownloaded = DateTime.Parse("05-07-1997") };

            Song s4 = new Song { Name = "Mercy", Artist = "Shawn Mendes", SongType = "Jazz", Rating = 4.8, NumberOfDownloads = 214500, DateDownloaded = DateTime.Parse("04-05-2016") };

            // create a list of songs

            List<Song> songList = new List<Song> { s1, s2, s3, s4 };

            // create a SongBO object

            SongBO songBO = new SongBO();

            // find songs by type

            List<Song> songsOfTypePop = songBO.FindSong(songList, "Pop");

            Console.WriteLine("Songs of type 'Pop':");

            foreach (Song song in songsOfTypePop)

            {

                Console.WriteLine(song);

            }

            // find songs by date downloaded

            DateTime date = DateTime.Parse("04-05-2016");

            List<Song> songsDownloadedOnDate = songBO.FindSong(songList, date);

            Console.WriteLine("Songs downloaded on {0:dd-MM-yyyy}:", date);

            foreach (Song song in songsDownloadedOnDate)

            {

                Console.WriteLine(song);

            }

            // find songs by rating

            double rating = 4.5;

            List<Song> songsWithRating = songBO.FindSong(songList, rating);

            Console.WriteLine("Songs with a rating of {0}:", rating);

            foreach (Song song in songsWithRating)

            {

                Console.WriteLine(song);

            }

        }

    }
}



















