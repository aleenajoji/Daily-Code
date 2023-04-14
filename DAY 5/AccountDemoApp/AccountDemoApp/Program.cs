using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
           Account a = null;
            do
            {
                Console.WriteLine();
                Console.WriteLine("1.Create Account");
                Console.WriteLine("2.Display Account Info");
                Console.WriteLine("3.Deposite Account");
                Console.WriteLine("4.Withdraw Account");
                Console.WriteLine("0.Quit");
                Console.WriteLine("Enter choice :");
                Console.WriteLine();
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter account Id");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter name");
                        String name = Console.ReadLine();
                        Console.WriteLine("Enter opening balance");
                        decimal balance = Decimal.Parse(Console.ReadLine());
                        a = new Account();
                        a.CreateAccount(id, name, balance);
                        break;
                    case 2:
                        if (a != null)
                            a.DisplayInfo();
                        else Console.WriteLine("Open Account First");
                        break;
                    case 3:
                        if (a != null)
                            a.Deposite(1000);
                        else Console.WriteLine("Open Account First");
                        break;  
                        case 4:
                        if (a != null)
                            a.Deposite(1000);
                        else Console.WriteLine("Open Account First");
                        break;
                    case 0:
                        break;
                        default: Console.WriteLine("Wrong choice");
                        break;


                }

            } while (ch != 0);
            
                Console.WriteLine("Thank you for using this App");
            
        }
    }
}
