using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallg3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arry = new int[6][];
            for (int i = 0; i < 6; i++)
            {
                arry[i] = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse) ;
            }
            int result = hourhourglass(arry);
            Console.WriteLine(result);
        }
        public static int hourhourglass(int[][] arry)
        {
            int maxSum = 0;
            for (int i = 0;i < 4;i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int sum = arry[i][j] + arry[i][j+1]+ arry[i][j+2]+
                        arry[i+1][j+1]+
                        arry[i+2][j]+ arry[i + 2][j+1]+ arry[i + 2][j + 2];
                    maxSum = Math.Max(maxSum, sum);
                }
                
            }
            return maxSum;
        }
    }
}
