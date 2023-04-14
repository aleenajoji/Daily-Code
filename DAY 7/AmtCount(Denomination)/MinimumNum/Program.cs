using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an amount");
            int amt=int.Parse(Console.ReadLine());
            for (int i = 0; i < amt; i++)
            {
                int num = amt / 2000;
                amt = amt % 2000;
                Console.WriteLine("Number of notes of 2000 {0}", num);
                
                num = amt / 500;
                amt = amt % 500;
                Console.WriteLine("Number of notes of 500 {0}", num);
                num = amt / 100;
                amt = amt % 100;
                Console.WriteLine("Number of notes of 100 {0}", num);
                 num = amt / 10;
                amt = amt % 10;
                Console.WriteLine("Number of notes of 10 {0}", num); 
                 num = amt / 5;
                amt = amt % 5;
                Console.WriteLine("Number of coins of 5 {0}", num);
                num = amt / 2;
                amt = amt % 2;
                Console.WriteLine("Number of coins of 2 {0}", num);
                num = amt / 1;
                amt = amt % 1;
                Console.WriteLine("Number of coins of 1 {0}", num);
                Console.WriteLine("Balance amount {0}",amt);
            }




        }
    }
}
