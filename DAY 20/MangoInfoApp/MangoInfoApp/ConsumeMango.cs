using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoInfoApp
{
    internal class ConsumeMango
    {
        public void SqueeezeMango(object sender, MangoEventArgs e)
        {
            Console.WriteLine("Squeezing " + e.Number
            + " of " + e.MangoInfo + " mangoes");
        }
    }
}
