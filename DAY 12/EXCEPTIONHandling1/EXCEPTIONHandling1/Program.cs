using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXCEPTIONHandling1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 10;
            int i= 0;
            try
            {
                i=int.Parse(Console.ReadLine());
                k = k /i;
                Console.WriteLine("Heloo");

            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
        }
    }
}
