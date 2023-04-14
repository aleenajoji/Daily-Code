using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrFig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Square();
            figure.dimenstion = 10;
            Console.WriteLine(figure.Area());
            Console.WriteLine(figure.Perimeter());


            Figure c1 = new Circle();
            figure.dimenstion = 5;
            Console.WriteLine(figure.Area());
            Console.WriteLine(figure.Perimeter());

        }
    }
    
}
