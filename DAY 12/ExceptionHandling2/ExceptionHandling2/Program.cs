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
            int b = 0; int[] a=new int[5];
            
            try
            {
                int i = 10 / b;
                a[4] = 9;
                Console.WriteLine("Heloo");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide By Zero Exception");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index Out Of Range Exception");
            }
            finally {
                int k=10, g=66;
                k = k + g;
                Console.WriteLine(k);
                Console.WriteLine("Remining"); }
        }
    }
}

