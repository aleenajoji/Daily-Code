using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in array");
            int num=int.Parse(Console.ReadLine());
            int[] array = new int[num];
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < num; i++)
            {
                array[i] = int.Parse(Console.ReadLine());   
            }
            Console.WriteLine();
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(array[i]);
            }


        }
    }
}
