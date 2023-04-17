using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collectDemo1
{
    

        class Program

        {

            static void Main(string[] args)

            {

                ArrayList ilist = new ArrayList { 50, 20, 30 };

                ilist.Sort();

                foreach (var item in ilist)

                {

                    Console.WriteLine(item);

                }



                ArrayList el = new ArrayList

      {

        new Emp(101, "Ram", 5000M),

        new Emp(102, "Shyam", 2000M),

        new Emp(103,"Hari",3500M)

      };

                foreach (var item in el)

                {

                    Console.WriteLine(item);

                }

                Console.WriteLine("Sorting");

                el.Sort();

                foreach (var item in el)

                {

                    Console.WriteLine(item);

                }

            }

        }

    }





