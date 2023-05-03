using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFruitFlower
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string[] flowers = { "dalia", "rose", "lotus", "lily", "daffodils" };
            string[] fruits = { "mango", "apple", "orange" };
            var fQuery = from flower in flowers

                         from fruit in fruits
                         select new{Flower = flower, Fruit = fruit};
            foreach (var f in fQuery)
            {
                Console.WriteLine(f.Flower + "," + f.Fruit);

            }

        }
    }
}
