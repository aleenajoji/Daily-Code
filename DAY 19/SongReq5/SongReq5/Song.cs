using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongReq5
{
    internal class Song

    {




        public Song() { }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }

        private string _artist;
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }

        }
        private string _songType;
        public string SongType
        {
            get { return _songType; }
            set { _songType = value; }

        }
        private double _rating;
        public double Rating
        {
            get { return _rating; }
            set { _rating = value; }

        }
        private int _numberOfDownloads;
        public int NumberOfDownloads
        {
            get { return _numberOfDownloads; }
            set { _numberOfDownloads = value; }

        }
        private DateTime _dateDownloaded;
        public DateTime DateDownloaded
        {
            get { return _dateDownloaded; }
            set { _dateDownloaded = value; }

        }
        public Song(string name, string artist, string songType,DateTime dateDownloaded, double
            rating, int numberOfDownloads)
        {
            _name = name;
            _artist = artist;
            _songType = songType;
            _rating = rating;
            _numberOfDownloads = numberOfDownloads;
            _dateDownloaded = dateDownloaded;
        }
    


    public static SortedDictionary<string, int> CalculateTypeCount(List<Song> list)
        {
            SortedDictionary<string, int> sd1 = new SortedDictionary<string, int>();
            foreach (var item in list)
            {
                if (sd1.ContainsKey(item.SongType))
                {
                    sd1[item.SongType]++;
                }
                else
                {
                    sd1.Add(item.SongType, 1);
                }
            }
            return sd1;


        }
    }
}
