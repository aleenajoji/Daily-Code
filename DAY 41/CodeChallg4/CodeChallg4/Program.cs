using System;

using System.Text.RegularExpressions;

class Solution

{

    static void Main(string[] args)

    {

        Console.WriteLine("Enter the number of strings");
        int num = int.Parse(Console.ReadLine());
        string[] newStr = new string[num];
       
        string pattern = @"\b(\w+)\b(\s+\1\b)+";

        for (int i = 0; i < num; i++)

        {
            Console.WriteLine("Enter string {0}",i+1);
            string sentence = Console.ReadLine();
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            string replaced = regex.Replace(sentence, "$1");

            newStr[i] = replaced;

        }

        Console.WriteLine("Modified strings:");


        for (int i = 0; i < num; i++)

        {

            Console.WriteLine(newStr[i]);
            Console.WriteLine();

        }

    }

}













