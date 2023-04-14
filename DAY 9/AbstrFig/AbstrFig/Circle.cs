using System;

namespace AbstrFig
{
    internal class Circle : Figure
    {
        public override double Area()
        {
            return Math.PI * dimenstion * dimenstion;
            
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * dimenstion;
        }
    }
}