using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongReq4
{
    
        internal class Song : IComparable<Song>
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
            public Song(string name, string artist, string songType, double
                rating, int numberOfDownloads, DateTime dateDownloaded)
            {
                _name = name;
                _artist = artist;
                _songType = songType;
                _rating = rating;
                _numberOfDownloads = numberOfDownloads;
                _dateDownloaded = dateDownloaded;
            }

            public override string ToString()
            {
                return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", _name, _artist, _songType, _rating.ToString("0.0"), _numberOfDownloads, _dateDownloaded);


            }

            //this CompareTo method is for sorting of songs list in the order of names
            //DEfault Comparer
            public int CompareTo(Song other)
            {
                Console.WriteLine(this.Name);
                return this.Name.CompareTo(other.Name);
            }

        }
    }


