using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a three digit num");
            int num = int.Parse(Console.ReadLine());
           
            isArmstrong(num);
        }



            static void isArmstrong(int num)
            {
            int a, digit = 0,temp;
            temp = num;

            while (temp > 0)
                {
                    a = temp % 10;
                    digit = digit + (a * a * a);
                    temp = temp / 10;
                }
                if (digit == num)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        
    }
}
