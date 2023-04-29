using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangoInfoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsumeMango Slice = new ConsumeMango();
            ProduceMango SalemFarms = new ProduceMango("Alphanso");
            // Slice registers event with SalemFarms
            SalemFarms.MangoInfo += Slice.SqueeezeMango;
            SalemFarms.FreshLot();
        }
    }
}
