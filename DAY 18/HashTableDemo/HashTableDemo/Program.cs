using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add("Maharastra", "Mango");
            h.Add("Kerala", "Coconut");

            Console.WriteLine("Element in list");

            IDictionaryEnumerator e =h.GetEnumerator();
            while (e.MoveNext()) {
                Console.WriteLine(e.Key +" : "+ e.Value);
            }
            ICollection k = h.Keys;
            {
                foreach (string item in h.Keys) 
                Console.WriteLine(item);
            }
            ICollection v = h.Values;
            {
                foreach (string item in h.Values)
                    Console.WriteLine(item);
            }
        }
    }
}
