using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape();//SHAPE
            s1.DrawShape();
            Circle c1 = new Circle();//CIRCLE
            c1.DrawShape();
            Shape s2 = new Circle();//UPCASTING (CIRCLE)
            s2.DrawShape();
            Rectangle r1 = new Rectangle();//RECTANGLE
            r1.DrawShape(); 
            Shape r2 = new Rectangle(); //UPCASTING (RECTANGLE)
            r2.DrawShape();
            // Array of references of base class containing referencing
            //Derived class object (UPCASTING)
            Shape[] p ={
                new Circle(),
            new Rectangle(),
            new Circle(),   
            new Rectangle(),
            new Circle(),

            };
            for (int i = 0; i < p.Length; i++)
            {
                p[i].DrawShape();
            }

            Shape t = null;
            Console.WriteLine("Enter Shape");
            String shape = Console.ReadLine();
            if (shape.ToLower() == "circle")
            {
                t=new Shape();
            }
            else if (shape.ToLower() == "rectangle")
            {
                t=new Rectangle();
            } 
            t.DrawShape();

        }

        
    }
}
