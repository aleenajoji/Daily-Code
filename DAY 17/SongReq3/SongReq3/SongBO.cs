using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongReq3
{


    public class Song

    {

        public string Name { get; set; }

        public string Artist { get; set; }

        public string SongType { get; set; }

        public double Rating { get; set; }

        public int NumberOfDownloads { get; set; }

        public DateTime DateDownloaded { get; set; }

        public override string ToString()

        {

            return string.Format("{0,-20} {1,-15} {2,-15} {3,-10} {4,-15} {5,-15}",

              Name, Artist, SongType, Rating, NumberOfDownloads, DateDownloaded.ToString("dd-MM-yyyy"));

        }

    }

    public class SongBO

    {

        public List<Song> FindSong(List<Song> songList, string type)

        {

            List<Song> result = new List<Song>();

            foreach (Song song in songList)

            {

                if (song.SongType == type)

                {

                    result.Add(song);

                }

            }

            return result;

        }

        public List<Song> FindSong(List<Song> songList, DateTime dateCreated)

        {

            List<Song> result = new List<Song>();

            foreach (Song song in songList)

            {

                if (song.DateDownloaded == dateCreated.Date)

                {

                    result.Add(song);

                }

            }

            return result;

        }

        public List<Song> FindSong(List<Song> songList, double rating)

        {

            List<Song> result = new List<Song>();

            foreach (Song song in songList)

            {

                if (song.Rating == rating)

                {

                    result.Add(song);

                }

            }

            return result;

        }

    }
}
