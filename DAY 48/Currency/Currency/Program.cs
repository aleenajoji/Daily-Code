using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Culture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount = 12324.134;

            CultureInfo usCulture = new CultureInfo("en-US");
            CultureInfo indiaCulture = new CultureInfo("en-IN");
            CultureInfo chinaCulture = new CultureInfo("zh-CN");
            CultureInfo franceCulture = new CultureInfo("fr-FR");

            string usFormatted = amount.ToString("C", usCulture);
            string indiaFormatted = amount.ToString("C", indiaCulture);
            string chinaFormatted = amount.ToString("C", chinaCulture);
            string franceFormatted = amount.ToString("C", franceCulture);

            Console.WriteLine("US: " + usFormatted);
            Console.WriteLine("India: " + indiaFormatted);
            Console.WriteLine("China: " + chinaFormatted);
            Console.WriteLine("France: " + franceFormatted);
        }
    }
}