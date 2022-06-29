using System;
using System.Collections;
using System.Linq;

namespace FinalProject
{
    public class CurrencyCalculator
    {
        public static double ConvertCurrency(string currencyFrom, string currencyTo, double currencyAmount)
        {
            double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (currencyFrom,currencyTo)
            {
                case "USD","EUR":
                    result = currencyAmount * someNum;
                    break;
                case "USDGBP":
                    result = currencyAmount * someNum;
                    break;
                case "USDCAD":
                    result = currencyAmount * someNum;
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("C# CURRENCY CALCULATOR");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.WriteLine("AVAILABLE CURRENCIES:");
            Console.WriteLine();
            var CurrencyList = new Dictionary<string, string>()
        {
            {"United States Dollar", "USD"},
            {"The EURO", "EUR"},
            {"British Pound Sterling", "GBP"},
            {"Canadian Dollar", "CAD"},
            {"Australian Dollar", "AUD"},
            {"Chinese Yuan", "CNY"},
            {"Japanese Yen", "JPY"},
            {"Hong Kong Dollar", "HKD"},
        };

            foreach (var currency in CurrencyList)
            {
                Console.WriteLine($"\t{currency.Key}: {currency.Value}");
            }
            Console.WriteLine();

            string currencyFrom;
            string currencyTo;
            double currencyAmount;

            Console.WriteLine("Enter three-letter currency code you want to convert FROM: ");
            currencyFrom = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Enter three-letter currency code you want to convert TO: ");
            currencyTo = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Enter numerical amount you want to convert: ");
            currencyAmount = Convert.ToDouble(Console.ReadLine());

            //bool CurrencyListHasCurrency1 = CurrencyList.ContainsValue(currencyCode1);
            

            //    bool endApp = false;
            //    // Display title as the C# console calculator app.
            //    Console.WriteLine("Currency Calculator in C#\r");
            //    Console.WriteLine("------------------------\n");

            //    while (!endApp)
            //    {
            //        // Declare variables and set to empty.
            //        string strInput1 = "";
            //        string strInput2 = "";
            //        double result = 0;

            //        // Ask the user to type the FROM currency
            //        Console.Write("Type what currency you want to convert FROM: ");
            //        strInput1 = Console.ReadLine();

            //        //double cleanNum1 = 0;
            //        //while (!double.TryParse(strInput1, out cleanNum1))
            //        //{
            //        //    Console.Write("This is not valid currency abbreviation. Please enter a three-letter currency abbreviation: ");
            //        //    strInput1 = Console.ReadLine();
            //        //}

            //        // Ask the user to type the TO currency.
            //        Console.Write("Type what currency you want to convert TO: ");
            //        strInput2 = Console.ReadLine();

            //        //double cleanNum2 = 0;
            //        //while (!double.TryParse(strInput2, out cleanNum2))
            //        //{
            //        //    Console.Write("This is not valid currency abbreviation. Please enter a three-letter currency abbreviation: ");
            //        //    strInput2 = Console.ReadLine();
            //        //}

            //        // Ask the user to choose an operator.

            //        string op = Console.ReadLine();

            //        try
            //        {
            //            result = CurrencyCalculator.DoOperation(cleanNum1, cleanNum2, op);
            //            if (double.IsNaN(result))
            //            {
            //                Console.WriteLine("This operation will result in a mathematical error.\n");
            //            }
            //            else Console.WriteLine("Your result: {0:0.##}\n", result);
            //        }
            //        catch (Exception e)
            //        {
            //            Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
            //        }

            //        Console.WriteLine("------------------------\n");

            //        // Wait for the user to respond before closing.
            //        Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
            //        if (Console.ReadLine() == "n") endApp = true;

            //        Console.WriteLine("\n"); // Friendly linespacing.
            //    }
            //    return;
            //}
        }
    }
}