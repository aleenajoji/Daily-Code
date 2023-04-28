

using System;

using System.Collections.Generic;

namespace SongReq4

{

    internal class Program

    {

        static void Main(string[] args)

        {

            List<Song> ls = SongRepo.GetAllSongs();

            int ch;

            do

            {

                Console.WriteLine("Enter a type of sort:");

                Console.WriteLine("\n1.Sort by Name");

                Console.WriteLine("\n2.Sort by Rating");

                Console.WriteLine("\n3.Sort by Popularity");

                Console.WriteLine("\n4.Exit");

                Console.Write("\nEnter Choice:");

                ch = int.Parse(Console.ReadLine());

                switch (ch)

                {

                    case 0:

                        Console.WriteLine("Name\t\t\t\tArtist\t Song Type\tRating\tNo of Downloads\tDate Downloaded");

                        

                        foreach (Song s in ls)

                        {

                            Console.WriteLine(s);

                        }

                        Console.WriteLine();

                        break;

                    case 1:

                        ls.Sort();

                        Console.WriteLine("Sorted Song List on Name:");

                        Console.WriteLine("Name\t\t\t\tArtist\t Song Type\tRating\tNo of Downloads\tDate Downloaded");

                      

                        foreach (Song s in ls)

                            Console.WriteLine(s);

                        Console.WriteLine();

                        break;

                    case 2:

                        ls.Sort(new RatingComparer());

                        Console.WriteLine("Sorted Song List on Rating:");

                        Console.WriteLine("Name\t\t\t\tArtist\t Song Type\tRating\tNo of Downloads\tDate Downloaded");

                      

                        foreach (Song s in ls)

                            Console.WriteLine(s);

                        Console.WriteLine();

                        break;

                    case 3:

                        ls.Sort(new PopularityComparer());

                        Console.WriteLine("Sorted Song List on Popularity:");

                        Console.WriteLine("Name\t\t\t\tArtist\t Song Type\tRating\tNo of Downloads\tDate Downloaded");

                      
                        foreach (Song s in ls)

                            Console.WriteLine(s);

                        break;

                    case 4:

                        break;

                    default:

                        Console.WriteLine("Invalid Choice");

                        break;

                }

            } while (ch != 0);

            Console.WriteLine();

        }

    }

}








