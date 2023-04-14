using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size");
            int n=int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                int mult = n * i;
                Console.WriteLine("{0}*{1}={2}",n,i,mult);
                    }
        }
    }
}
