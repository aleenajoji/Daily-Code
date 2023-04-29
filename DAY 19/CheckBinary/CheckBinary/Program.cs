using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = null;

            Console.WriteLine("Input a number");
           
            str = Console.ReadLine();
            bool r=IsBinary(str);
            if (r == false)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("1");
            }
            
        }
        public static bool IsBinary(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '1' && str[i] != '0')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
