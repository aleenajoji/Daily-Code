
using System;
namespace ExtentionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Welcome to hello world hi";

            int wordCount = myFun.GetWordCount(s);

            Console.WriteLine(wordCount);
            
        }
    }

    public static class myFun
    {
        public static int GetWordCount(this string str)
        {
            if (!String.IsNullOrEmpty(str))
                return str.Split(' ').Length;
            return 0;
        }
    }
}