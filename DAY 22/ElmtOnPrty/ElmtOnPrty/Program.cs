using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try101LinqSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = Products.GetProductList();
            

            var soldOutProducts = from prod in products
                                  where prod.UnitsInStock == 0
                                  select prod;

            Console.WriteLine("Sold out products:\n");
            foreach (var product in soldOutProducts)
            {
                Console.WriteLine($"{product.ProductName} is sold out!");
            }
           

            var expensiveInStockProducts = from prod in products
                                           where prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M
                                           select prod;

            Console.WriteLine("In-stock products that cost more than 3.00:\n");
            foreach (var product in expensiveInStockProducts)
            {
                Console.WriteLine($"{product.ProductName} is in stock and costs more than 3.00.");
            }
        }
    }
}
