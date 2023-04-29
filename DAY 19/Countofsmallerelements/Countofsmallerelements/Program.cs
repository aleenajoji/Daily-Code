using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countofsmallerelements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter array size");
            int size=int.Parse(Console.ReadLine());
            int[] arr = new int[size];
         
            Console.WriteLine("Enter array elements");
            
            for( int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine()) ;   
            }
            Console.WriteLine("Enter array element which to be compared");
            int elemt = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= elemt)
                {
                    count++;
                }
            }
            Console.WriteLine("The number of elemts less than {0} is {1}",elemt,count);
        }
    }
}
