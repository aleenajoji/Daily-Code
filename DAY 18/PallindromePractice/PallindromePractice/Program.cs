using System;

namespace PallindromePractice

{

    internal class Program

    {
        static void Main(string[] args)

        {
            int i,num;
            
            Console.WriteLine("Enter the array size");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k];
            Console.WriteLine("Enter array elements");
            for (i = 0; i < k; i++)

            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            if (PallitArray(k, arr) == 1)

            {
                Console.WriteLine("All elements of the array are pallindrome.");

            }
            else

            {
                Console.WriteLine("Array contains non-pallindrome elements.");
            }

            Console.ReadLine();
        }
        public static int checkPallit(int num)

        {

            int temp, rev = 0;
            temp = num;
            while (temp > 0)
            {
                int a = temp % 10;
                rev = rev * 10 + a;
                temp = temp / 10;
            }

            if (rev == num)
            {
                return 1;

            }
            else

            {
                return 0;

            }
        }

        public static int PallitArray(int k, int[] arr)

        {

            for (int i = 0; i < k; i++)

            {

                if (checkPallit(arr[i]) == 0)

                {

                    return 0;

                }

            }

            return 1;

        }

    }

}























/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PallindromePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Enter the number");
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the array size");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array elemts");
            for(i = 0; i < k; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }

            if(PallitArray( k, arr) == 1)
            {

            }


        }
        public int checkPallit(int num)
        {
            int temp,rev=0;
           temp = num ;
            while(temp > 0)
            {
                int a= temp%10;
                rev = rev * 10 + a;
                temp = temp/10;
            }
            if (rev == num)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int PallitArray(int k, int[] arr) {
            for (int i = 0; i < k; i++)
            {
                if (checkPallit ( arr[i])==0)
                {
                    return 0;
                }
            }
            return 1;
        }
        
    }
}*/
