using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallg1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=int.Parse(Console.ReadLine());

            Inner.Private IP = new Inner.Private();
            IP.Power2(num);
           

        }
        public class Inner
        {
           public class Private
            {
               public void Power2(int num)
                {
                   if ((num & (num - 1)) == 0)
                    {
                        Console.WriteLine("{0} is power of 2",num);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not power of 2",num);
                    }
                } 

            }


        }
    }
}







/*int flag = 0;
            Console.WriteLine("Enter a number");
           int  num=int.Parse(Console.ReadLine());
            int number=num;
            
            
            for (int i = 0; i < num; i++)
            {
                if (num % 2 != 0 && num > 0)
                {
                    
                    flag = 1;
                }
                num = num / 2;
            }
            if (flag == 1)
            {
                Console.WriteLine("Number is not power of 2");
            }
            else
            {
                Console.WriteLine("{0} is power of {1}", number, num);
               
            }
            */