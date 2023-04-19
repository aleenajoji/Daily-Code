using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligateDemo
{
    

    

        class Program

        {

            static void Add(int i, int j)

            {

                Console.WriteLine("Sum :" + (i + j));

            }

            static void Sub(int i, int j)

            {

                Console.WriteLine("Sub :" + (i - j));

            }

            public delegate void reftomethod(int i, int j);

            static void Main(string[] args)

            {

                Add(10, 20);

                reftomethod r1 = Add;

                r1(10, 20);

                reftomethod r2 = Sub;

                r2.Invoke(10, 20);

            }

        }

    }



