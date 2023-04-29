using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorDemo
{
    class Reactor
    {
        private int temperature;
        public delegate void MeltdownHandler(
        object reactor, MeltdownEventArgs myMEA);
        public event MeltdownHandler OnMeltdown;
        public int Temperature
        {
            set
            {
                temperature = value;
                if (temperature > 1000)
                {
                    MeltdownEventArgs myMEA = new MeltdownEventArgs("Reactor meltdown in progress!");
                    OnMeltdown(this, myMEA);
                }
            }
        }
    }
}
