using System;
class Program
{
    static void Main(string[] args)

    {
        int[] intArray = { 1, 2, 3 };
        string[] stringArray = { "Hello", "World" };
        PrintArray(intArray);
        PrintArray(stringArray);
    }

    static void PrintArray<T>(T[] array)
    {
        foreach (T element in array)
        {
            Console.WriteLine(element);
        }

    }

}


