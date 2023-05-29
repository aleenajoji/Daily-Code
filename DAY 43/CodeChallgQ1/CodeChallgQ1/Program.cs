using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallgQ1

{
    class Program

    {
        static void Main(string[] args)

        {
            
           int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;
            foreach (int num in arr)
            {
               if (num > 0)
                    positiveCount++;
                else if (num < 0)
                    negativeCount++;
                else
                    zeroCount++;
            }
            double positiveRatio = (double)positiveCount / n;
            double negativeRatio = (double)negativeCount / n;
            double zeroRatio = (double)zeroCount / n;
            Console.WriteLine(positiveRatio.ToString("F6"));
            Console.WriteLine(negativeRatio.ToString("F6"));
            Console.WriteLine(zeroRatio.ToString("F6"));

        }

    }

}

