using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorDemo
{
    class ReactorMonitor
    {
        public ReactorMonitor(Reactor myReactor)
        {
            myReactor.OnMeltdown += new Reactor.MeltdownHandler(DisplayMessage);
        }
        public void DisplayMessage(object myReactor, MeltdownEventArgs myMEA)
        {
            Console.WriteLine(myMEA.Message);
        }
    }

}
