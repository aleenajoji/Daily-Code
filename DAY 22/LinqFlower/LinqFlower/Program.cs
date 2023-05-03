using LinqFlower;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFlower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dalia", "rose", "lotus", "lily", "daffodils" };
            
            var fQuery = from flower in flowers
                         
                         where (flower.StartsWith("d"))
                         select flower;
            foreach (string f in fQuery) {
                Console.WriteLine(f);
            }
           
        }
    }
}
