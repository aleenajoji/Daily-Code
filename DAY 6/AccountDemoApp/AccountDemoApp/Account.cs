using System;

namespace AccountDemoApp
{
    public class Account
    {
        public int Id;
        public string _name;
        
        private decimal _balance;
        public decimal Balance
        {
            get
            {
                return _balance;
            }
            
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set { if (value.Length > 15)
                    throw new ArgumentException("Name is too big");
            _name = value;
            }  
        }
        
        public void CreateAccount(int id, string name, decimal balance)
        {
           Id = id;
           _name = name;
           _balance = balance;
        }

            public void Deposite(decimal amount)
            {
                
            _balance += amount;
            Console.WriteLine("{0} Deposited",amount);
            }

        public void DisplayInfo()
        {
            Console.WriteLine("Account Information");
            Console.WriteLine("Account Id :"+Id);
            Console.WriteLine("Name :"+Name);
            Console.WriteLine("Balance : "+Balance);
        }
        public void withdraw(decimal amount)
        {
            if (_balance - amount < 1000)
                Console.WriteLine("Insufficient Balance");
            else
                this._balance = amount;
            Console.WriteLine("{0} withdraw",amount);
        }
    }
}