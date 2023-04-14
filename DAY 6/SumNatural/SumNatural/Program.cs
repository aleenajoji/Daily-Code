using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNatural
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0 , n , i=0;
          
            Console.WriteLine("Enter the size");
            n=int.Parse(Console.ReadLine());
            for(i = 1; i<=n; i++) {
                Console.WriteLine(i);
                sum += i;

            }
            
            Console.WriteLine(sum);
        }
    }
}
