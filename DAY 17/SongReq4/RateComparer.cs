using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongReq4
{
    
        internal class RatingComparer : IComparer<Song>
        {
            public int Compare(Song x, Song y)
            {
                //Descenting sort 
                return y.Rating.CompareTo(x.Rating);
            }
        }
    }


