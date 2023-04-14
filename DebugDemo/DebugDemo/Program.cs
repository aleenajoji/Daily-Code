using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st num");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2st num");
            int j = int.Parse(Console.ReadLine());
            Hiii(i, j);
            Console.WriteLine("Debugging");
        }
        public static void Hiii(int x, int y)
        {
            int t = 100;
            for (int i = x; i <= y; i++)
            {
                Console.WriteLine("Hello");
                t = t + 30;
            }

        }
    }
}
