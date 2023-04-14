using System;

namespace AccountDemoApp
{
    public class Account
    {
        public int Id;
        public string Name;
        public decimal Balance;
        
        public void CreateAccount(int id, string name, decimal balance)
        {
            this.Id = id;
            this.Name = name;
            this.Balance = balance;
        }

            public void Deposite(decimal amount)
            {
                
            Balance += amount;
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
            if (Balance - amount < 1000)
                Console.WriteLine("Insufficient Balance");
            else
                this.Balance = amount;
        }
    }
}