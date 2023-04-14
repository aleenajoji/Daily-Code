using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteDiff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0, AbsD;
            Console.WriteLine("Enter number greater than 51");
            n = int.Parse(Console.ReadLine());
            AbsD = CalAb(n);
            Console.WriteLine(AbsD);
        }
        static int CalAb(int n)
        {
            int x = 51;
            if (n > x)
            {
                return (n - x) * 3;
            }
            return (n - x);

        }

    }

