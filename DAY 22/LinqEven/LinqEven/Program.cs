using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 5, 2, 4, 7, 8, 19 };
            var num = from n in ar
                      where n%2 == 0
                      select n;
            foreach (var x in num) {
                Console.WriteLine(x +" ");
            }
        }
    }
}
