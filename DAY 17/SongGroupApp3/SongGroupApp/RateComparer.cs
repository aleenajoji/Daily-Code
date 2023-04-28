using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongGroupApp
{
    internal class RateComparer : IComparer<Song>
    {
        public int Compare(Song x, Song y) { 
            //Descenting sort 
            return y.Rating.CompareTo(x.Rating);
        }
    }
}
