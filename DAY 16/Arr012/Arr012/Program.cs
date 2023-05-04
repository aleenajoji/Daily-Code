using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;


//Printing the array of 0's ,1's, 2's


namespace Arr012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the size of array");
            int n=int.Parse(Console.ReadLine());   
            Console.WriteLine("Enter the array elements");
            int[] arr=new int[n];
            for(int i=0; i<n; i++)
                arr[i]=int.Parse(Console.ReadLine());
            sort(arr);
            for (int i = 0; i < n; i++)
                Console.WriteLine(arr[i]);


        }
        static int[] sort(int[] arr) {
            int countZero = 0, countOne = 0;
            for (int i = 0; i < arr.Length; i++) { 
                if (arr[i] == 0)
                {
                    countZero++;
                }
            if (arr[i] == 1) { countOne++; } }
            for(int i=0 ; i<(countZero) ; i++)
            {
                arr[i] = 0;
            }
            for (int i = countZero; i < (countZero+countOne); i++)
            {
                arr[i] = 1;
            }
            for (int i = (countZero + countOne); i < arr.Length; i++)
            {
                arr[i] = 2;
            }
            return arr;

        }

    }
}
