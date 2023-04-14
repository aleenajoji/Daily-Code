using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String ans, res;
        
          
            Console.Write("Enter the number ");
            ans = Console.ReadLine();
            int num=Convert.ToInt32(ans);
            res = "";
            
            while(num>1) { 
            
                int rem = num % 2;
                res=Convert.ToString(rem) + res;
                num = num / 2;
            }
            res = Convert.ToString(num) + res;
            Console.WriteLine("Binary {0}",res);
            }
        }
    }

