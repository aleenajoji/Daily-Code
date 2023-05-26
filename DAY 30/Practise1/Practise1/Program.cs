using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        // Define text to be parsed.
        string input = "Office expenses on 2/13/2008:\n" +
                       "Paper (500 sheets)                      $3.95\n" +
                       "Pencils (box of 10)                     $1.00\n" +
                       "Pens (box of 10)                        $4.49\n" +
                       "Erasers                                 $2.19\n" +
                       "Ink jet printer                        $69.95\n\n" +
                       "Total Expenses                        $ 81.58\n";

        
        NumberFormatInfo nfi = CultureInfo.CurrentCulture.NumberFormat;
       
        string currencySymbol = nfi.CurrencySymbol;
        bool symbolPrecedesIfPositive = nfi.CurrencyPositivePattern % 2 == 0;
        string groupSeparator = nfi.CurrencyGroupSeparator;
        string decimalSeparator = nfi.CurrencyDecimalSeparator;

        
        string pattern = Regex.Escape(symbolPrecedesIfPositive ? currencySymbol : "") +
                         @"\s*[-+]?" + "([0-9]{0,3}(" + groupSeparator + "[0-9]{3})*(" +
                         Regex.Escape(decimalSeparator) + "[0-9]+)?)" +
                         (!symbolPrecedesIfPositive ? currencySymbol : "");
        Console.WriteLine("The regular expression pattern is:");
        Console.WriteLine("   " + pattern);

       
        MatchCollection matches = Regex.Matches(input, pattern,
                                                RegexOptions.IgnorePatternWhitespace);
        Console.WriteLine("Found {0} matches.", matches.Count);

       
        List<decimal> expenses = new List<Decimal>();

        foreach (Match match in matches)
            expenses.Add(Decimal.Parse(match.Groups[1].Value));

       
        decimal total = 0;
        foreach (decimal value in expenses)
            total += value;

        if (total / 2 == expenses[expenses.Count - 1])
            Console.WriteLine("The expenses total {0:C2}.", expenses[expenses.Count - 1]);
        else
            Console.WriteLine("The expenses total {0:C2}.", total);
    }
}
