using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dist = 0.0,time=0.0,Speed=0.0;
            Console.WriteLine("Enter the distance");
            dist = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the time");
            time = double.Parse(Console.ReadLine());
            Speed = kilo(dist,time);
            Speed = miles(dist,time);
            Console.WriteLine(Speed);
        }
        static double kilo(double dist,double time)
        {
            return (dist/time);

        }
        static double miles(double dist,double time)
        {
            return (dist/time)*0.621;
        }
        
    }
}
