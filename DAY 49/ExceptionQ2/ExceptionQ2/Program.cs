using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionQ2
{
    class MyCalculator
    {
        public int Power(int n, int p)
        {
            if (n < 0 || p < 0)
            {
                throw new Exception("n and p should be non-negative");
            }
            else if (n == 0 && p == 0)
            {
                throw new Exception("n and p should not be zero");
            }
            else
            {
                return (int)Math.Pow(n, p);
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] numbers = input.Split(' ');
                    int n = int.Parse(numbers[0]);
                    int p = int.Parse(numbers[1]);
                    MyCalculator myCalculator = new MyCalculator();
                    int result = myCalculator.Power(n, p);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}

