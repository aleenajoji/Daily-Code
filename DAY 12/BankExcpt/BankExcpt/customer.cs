using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExcpt
{
    class customer

    {

        string name; int accno; int balance;

        public customer(string n, int a, int b)

        {

            name = n;

            accno = a;

            balance = b;

        }

        public void withdraw(int amt)

        {

            if (balance - amt <= 100)

                throw new bankexception(accno, balance);

            balance -= amt;

        }

        public int getbalance()

        {

            return balance;

        }

    } // end of customer class
}
