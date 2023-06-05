using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptiontryatchqstn3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                int result = Divide(a, b);

                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                Console.WriteLine("java.util.InputMismatchException");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("java.lang.ArithmeticException: / by zero");
            }
        }
        static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
