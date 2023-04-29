using System;
public class ConvertFiveProgram

{
    public static void Main()

    {
        Console.WriteLine("How much number of elements to be converted");
        int T = int.Parse(Console.ReadLine());
        for (int i = 0; i < T; i++)

        {
            Console.WriteLine("Enter the number\t");
            int n = int.Parse(Console.ReadLine());
            int converted_n = ConvertFive(n);
            Console.WriteLine("After replacing 0's with 5 --> {0}",converted_n);

        }

    }

    public static int ConvertFive(int n)

    {
        int result = 0;
        int multiplier = 1;

        while (n > 0)

        {
            int digit = n % 10;
            if (digit == 0)

            {
                digit = 5;
            }

            result = digit * multiplier + result;
            multiplier *= 10;
            n /= 10;

        }
        return result;

    }

}

