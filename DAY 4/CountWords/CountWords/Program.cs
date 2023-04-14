using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Count the total number of words in a string
namespace CountWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int  word, l;
            Console.WriteLine("Input the string ");
            str = Console.ReadLine();

            l = 0;
            word = 1;
            while (l <= str.Length - 1)
            {
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    word++;
                }

                l++;
            }
            Console.WriteLine("Total number of words in the string is  {0}", word);
        }
    }
}
