using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            DateTime dt = new DateTime(2015,1,5);
            Console.WriteLine(dt);
            DateTime dt1 = new DateTime(2003, 4, 20);
            Console.WriteLine(dt1);
            Console.WriteLine(dt1.DayOfYear);
            Console.WriteLine(dt1.Year);
            Console.WriteLine(dt1.Minute);
            Console.WriteLine(dt1.Day);
            Console.WriteLine(dt1.Second);
            Console.WriteLine(dt1.Hour);
            Console.WriteLine(dt1.Month);
            DateTime dt3 = new DateTime(2015, 12, 31, 5, 10, 20);
            Console.WriteLine(dt3);
            DateTime dt4 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);
            Console.WriteLine(dt4);
            DateTime todaysDate = DateTime.Today;
            Console.WriteLine(todaysDate);

        }
    }
}
