using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyDemo
{
    public class Shape
    {
        public virtual void DrawShape()
        {
            Console.WriteLine("Draw Shape");
        }

    }
    public class Circle : Shape
    {
        public override void DrawShape()
        {
            Console.WriteLine("Draw Circle");
        }
    }
    public class Rectangle : Shape
    {
        public override void DrawShape()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }
}
