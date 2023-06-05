using System;

class Program
{
    static void Main(string[] args)
    {
        int lineNumber = 1;

        while (true)
        {
            string line = Console.ReadLine();

            if (line == null)
                break;

            Console.WriteLine($"{lineNumber} {line}");
            lineNumber++;
        }
    }
}