using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack();
            s1.Push(1);

            Queue q1 = new Queue();
            q1.Enqueue(1);

            ArrayList arlist= new ArrayList();
            Console.WriteLine(arlist.Capacity);
            arlist.Add(123);
            arlist.Add(234);
            arlist.Add(777);
            arlist.Add(99);
            arlist.Add("nzvvnv");
            arlist.Add(8888888);
            arlist.Add(99);
            arlist.Add(true);
            arlist.Add(new emp());
            Console.WriteLine(arlist.Capacity);
            foreach(object i in arlist) { 
            Console.WriteLine(i);
                
            }

        }
    }
}
