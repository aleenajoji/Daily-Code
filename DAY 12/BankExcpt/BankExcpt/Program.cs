using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExcpt
{
    public class Class1

    {

        static void Main(string[] args)

        {

            customer c = new customer("Rahul", 2453, 500);

            try

            {

                c.withdraw(450);

            }

            catch (bankexception e)

            {

                Console.WriteLine("Transaction Failed ");

                e.inform();

            }

        }

    }

}



