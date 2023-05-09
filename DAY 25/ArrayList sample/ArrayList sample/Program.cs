using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrlis = new ArrayList()
            {
                1,"Bill","doooo",10000

            };
            foreach(var i in arrlis)
            {
                Console.WriteLine(i);
            }
            foreach(var i in arrlis.GetRange(1,3))
            {
                Console.WriteLine(  i);
            }

        }
    }
}
