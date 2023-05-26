using System;



class Solution

{

    static bool CanWin(int leap, int[] game)

    {

        return CanWinGame(0, leap, game);

    }

    static bool CanWinGame(int currentIndex, int leap, int[] game)

    {

        if (currentIndex >= game.Length)

            return true;

        if (currentIndex < 0 || game[currentIndex] == 1)

            return false;

        game[currentIndex] = 1;

        return CanWinGame(currentIndex + leap, leap, game)

          || CanWinGame(currentIndex + 1, leap, game)

          || CanWinGame(currentIndex - 1, leap, game);

    }

    static void Main(string[] args)

    {

        int q = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < q; i++)

        {

            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int leap = Convert.ToInt32(nk[1]);

            int[] game = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

            bool canWin = CanWin(leap, game);

            Console.WriteLine(canWin ? "YES" : "NO");

        }

    }

}















