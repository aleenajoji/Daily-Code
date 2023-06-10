using System;
using System.Collections.Generic;
class Student { }
class Rockstar { }
class Hacker { }
class Solution

{
    static void Main(string[] args)

    {
        int count = int.Parse(Console.ReadLine());
        List<object> myList = new List<object>();
        for (int i = 0; i < count; i++)

        {
            string type = Console.ReadLine();
            if (type.Equals("Student"))

            {
                myList.Add(new Student());
            }

            if (type.Equals("Rockstar"))
            {
                myList.Add(new Rockstar());
            }

            if (type.Equals("Hacker"))

            {
                myList.Add(new Hacker());
            }

        }

        int studentCount = 0;
        int rockstarCount = 0;
        int hackerCount = 0;

        foreach (object obj in myList)
        {
            if (obj is Student)

            {
                studentCount++;
            }
            if (obj is Rockstar)
            {
                rockstarCount++;
            }

            if (obj is Hacker)
            {
                hackerCount++;

            }

        }
        Console.WriteLine($"{studentCount} {rockstarCount} {hackerCount}");

    }

}

