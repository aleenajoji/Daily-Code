using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongGroupApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string type = "Pop";*/
            List<Song> ls =SongRepo.GetAllSongs();
            {
                Console.WriteLine("name \t artist \t songtype \t datedownloaded \t date \t downloaded");
                foreach (Song s in ls)
                {
                    Console.WriteLine(s);

                }
                ls.Sort();
                Console.WriteLine("Sorting song list on Name");
                Console.WriteLine("name \t artist \t songtype \t datedownloaded \t date \t downloaded");
                foreach (Song s in ls)
                    Console.WriteLine(s);  
                Console.WriteLine();
                ls.Sort(new RateComparer());
                Console.WriteLine("Sorting Song list on rating");
                Console.WriteLine("name \t artist \t songtype \t datedownloaded \t date \t downloaded");
                foreach (Song s in ls)
                    Console.WriteLine(s);   

            }


        }
    }
}
