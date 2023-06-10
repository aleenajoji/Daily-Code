using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1q2
{
    internal class Program
        {
        public class Animal
            {
            public void walk()
                {
                    Console.WriteLine("I am walking");
                }
            }
            public class Bird : Animal
            {
            public void fly()
                {
                    Console.WriteLine("I am flying");
                }
                public void Sing()
                {
                    Console.WriteLine("I am singing");
                }
            }
            static void Main(string[] args)

            {
                Bird bird = new Bird();
                bird.walk();
                bird.fly();
                bird.Sing();
            }

        }    
}
