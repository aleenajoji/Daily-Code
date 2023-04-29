using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorDemo
{
   
        internal class Program
        {
            static void Main(string[] args)
            {
                Reactor myReactor = new Reactor();
                ReactorMonitor myReactorMonitor = new ReactorMonitor(myReactor);
                Console.WriteLine("Setting reactor temperature to 100 degrees Centigrade");

                myReactor.Temperature = 100;
                Console.WriteLine("Setting reactor temperature to 500 degrees Centigrade");

                myReactor.Temperature = 5000;
                Console.WriteLine("Setting reactor temperature to 2000 degrees Centigrade");

                myReactor.Temperature = 2000;

            }
        }
    
}
