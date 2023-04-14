using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrFig
{
    abstract class Figure
    {
        public int dimenstion;
        public abstract double Area();
        public abstract double Perimeter();
    }
    class Square : Figure
    {
        public override double Area()
        {
           return dimenstion*dimenstion;
        }
        public override double Perimeter()
        {
            return 4*dimenstion;
        }
    }
}
