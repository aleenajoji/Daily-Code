using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultcastDeligate
{
    using System;

    using System.Collections.Generic;

    using System.Linq;

    using System.Text;

    using System.Threading.Tasks;

    namespace DelegateDemo

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

                reftomethod multicast = Add;

                multicast += Sub;

                multicast(20, 10);

            }

        }

    }


}
