using System;
using System.Collections.Generic;
using System.IO;

class Result
{
    public static long Solve(List<int> arr)

    {
        Dictionary<int, long> frequency = new Dictionary<int, long>();
        long count = 0;
        foreach (int num in arr)
        {
            if (frequency.ContainsKey(num))
                frequency[num]++;
            else
                frequency[num] = 1;
        }
        foreach (var kvp in frequency)
        {
            long freq = kvp.Value;
            count += (freq * (freq - 1)) / 2;

        }

        return count;

    }

}

class Solution

{
    static void Main(string[] args)

    {
        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> arr = new List<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
       long result = Result.Solve(arr);
       Console.WriteLine(result);

    }

}









