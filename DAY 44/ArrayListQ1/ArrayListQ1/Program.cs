using System;
class Program

{
    static void Main()

    {

        int n = int.Parse(Console.ReadLine()); // Number of lines

        int[][] lines = new int[n][];
        for (int i = 0; i < n; i++)

        {
            string[] lineData = Console.ReadLine().Split(' ');
            int count = int.Parse(lineData[0]);
            lines[i] = new int[count];
           for (int j = 0; j < count; j++)

            {

                lines[i][j] = int.Parse(lineData[j + 1]);

            }

        }
        int q = int.Parse(Console.ReadLine()); // Number of queries
        for (int i = 0; i < q; i++)

        {
            string[] queryData = Console.ReadLine().Split(' ');
            int x = int.Parse(queryData[0]);
            int y = int.Parse(queryData[1]);

            if (x >= 1 && x <= n && y >= 1 && y <= lines[x - 1].Length)

            {
                Console.WriteLine(lines[x - 1][y - 1]);
            }
            else
            {
                Console.WriteLine("ERROR!");
            }

        }

    }

}











