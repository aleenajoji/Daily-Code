using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Finding the missing element from array
namespace MissinNO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0,total=0;
            Console.WriteLine("Enter size");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array elemts");
            int[] arr = new int[n];
            for (int i = 0; i < n-1; i++)
                arr[i] = int.Parse(Console.ReadLine());
            
            total = (n * (n + 1)) / 2;
            for (int i = 0; i < n ; i++) 
                sum = sum + arr[i];
            int missingElmt = total - sum;//taking difference between total number and sum of array
            Console.WriteLine("Missing Element {0}",missingElmt);
        }
    }
}
