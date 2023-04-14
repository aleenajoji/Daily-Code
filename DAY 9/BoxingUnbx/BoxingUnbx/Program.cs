using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnbx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;//boxing
            int j = (int)o;
            Console.WriteLine(j);   
        }
    }
}
