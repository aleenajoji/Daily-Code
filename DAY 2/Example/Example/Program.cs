using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
     class Program
    {
        //Program to calculate area of a circle
        static void Main(string[] args)
        {
            double radius = 0.0, Area;
            Console.WriteLine("Enter the radius");
             radius =double.Parse(Console.ReadLine());//user input
            Area = AreaC(radius);
            
            Console.WriteLine(Area);
        }
        static double AreaC(double radius) 
        {
            double Area; 
            Area =3.14 * radius* radius;
        return Area;
        }
    }
}
