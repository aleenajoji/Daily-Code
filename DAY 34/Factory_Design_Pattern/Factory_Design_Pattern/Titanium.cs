using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern
{
   
        public class Titanium : CreditCard
        {
            public string GetCardType()
            {
                return "Titanium Edge";
            }
            public int GetCreditLimit()
            {
                return 25000;
            }
            public int GetAnnualCharge()
            {
                return 1500;
            }
        }
    
}
