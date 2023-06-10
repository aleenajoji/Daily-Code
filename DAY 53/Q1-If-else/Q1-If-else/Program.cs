using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_If_else
{
    class Program

        {

            static void Main(string[] args)

            {

                Console.WriteLine("Enter the number");
                int n = int.Parse(Console.ReadLine());
                if (n % 2 != 0)

                {
                    Console.WriteLine("Weird");
                }

                else if (n % 2 == 0 && n > 2 && n < 5)
                {
                    Console.WriteLine("Not Weird");
                }
                else if (n % 2 == 0 && n > 6 && n < 20)

                {
                    Console.WriteLine("Weird");
                }
                else if (n % 2 == 0 && n > 20)

                {
                    Console.WriteLine("Not Weird");

                }
            }
        }
}
