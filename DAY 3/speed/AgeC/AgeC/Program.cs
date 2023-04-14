using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("enter candidate age");
            age = int.Parse(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("You are not eligible to vote");
            }
            else
            {
                Console.WriteLine("You are eligible to vote");
            }
        }
    }
}
