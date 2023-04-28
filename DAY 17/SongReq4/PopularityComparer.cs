using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongReq4
{
    internal class PopularityComparer : IComparer<Song>
    {
        public int Compare(Song x, Song y)
        {
            //Descenting sort 
            return y.NumberOfDownloads.CompareTo(x.NumberOfDownloads);
        }
    }
    
   
}
