using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous2
{
    public delegate int Addition(int a, int b); 
   class Program
    {
        static void Main(string[] args)
        {
            int sum = 1;
            Addition add = delegate (int n, int k)
            {
                return n + k;
            };
            sum = add(10, 20);
            Console.WriteLine(sum);

        }
    }
}
