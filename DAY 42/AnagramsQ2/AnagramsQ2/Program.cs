using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Anagram

{ public class Program

    {
        static void Main(string[] args)

        {

            Console.WriteLine("Enter String 1: ");

            string str1 = Console.ReadLine();

            Console.WriteLine("Enter String 2: ");

            string str2 = Console.ReadLine();

            if (Anagram(str1, str2))

            {

                Console.WriteLine("Anagram");

            }

            else

            {

                Console.WriteLine("Not Anagram");

            }

        }

        public static bool Anagram(string str1, string str2)

        {

            str1 = str1.ToLower();

            str2 = str2.ToLower();

            if (str1.Length != str2.Length)

            {

                return false;

            }

            int[] chrfrq = new int[26];

            foreach (char c in str1)

            {

                chrfrq[c - 'a']++;

            }

            foreach (char c in str2)

            {

                if (chrfrq[c - 'a'] == 0)

                {

                    return false;

                }

                chrfrq[c - 'a']--;

            }

            return true;

        }

    }

}





















