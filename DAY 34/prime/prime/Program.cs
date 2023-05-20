using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{


    class Program

    {

        static void Main(string[] args)

        {

            int number, i;

            Console.Write("Enter a Number :");

            number = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i < number; i++)

            {

                if (number % i == 0)

                {

                    break;

                }

            }
            for (i = 4; i < number; i++)

            {

                break;

            }


            if (i == number && number >= 2)

            {

                Console.WriteLine($"{number} is a Prime Number");

            }

            else

            {

                Console.WriteLine($"{number} is not a Prime Number");

            }

            Console.ReadKey();

        }

    }

}



