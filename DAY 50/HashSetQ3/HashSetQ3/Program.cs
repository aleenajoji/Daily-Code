using System;
using System.Collections.Generic;

class Solution

{
   static void Main(string[] args)

    {
        int n = int.Parse(Console.ReadLine());
        HashSet<string> pairs = new HashSet<string>();
        for (int i = 0; i < n; i++)
        {
            string[] pair = Console.ReadLine().Split(' ');
            string pairString = $"{pair[0]},{pair[1]}";
            pairs.Add(pairString);
            Console.WriteLine(pairs.Count);
        }
    }
}