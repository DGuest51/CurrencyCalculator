using System;
using System.Collections;
using System.Linq;

namespace FinalProject
{
    public class CurrencyCalculator
    {
        public static double ConvertCurrency(string currencyFrom, string currencyTo, double currencyAmount)
        {
            double result = 0;
            if (currencyFrom == "USD")
            {
                switch (currencyTo)
                {
                    case "EUR":
                        result = currencyAmount * 0.94;
                        break;
                    case "GBP":
                        result = currencyAmount * 0.81;
                        break;
                    case "CNY":
                        result = currencyAmount * 6.69;
                        break;
                    case "JPY":
                        result = currencyAmount * 135.87;
                        break;
                    default:
                        break;
                }
                return result;
            }
            else if (currencyFrom == "EUR")
            {
                switch (currencyTo)
                {
                    case "USD":
                        result = currencyAmount * 1.05;
                        break;
                    case "GBP":
                        result = currencyAmount * 0.86;
                        break;
                    case "CNY":
                        result = currencyAmount * 7.06;
                        break;
                    case "JPY":
                        result = currencyAmount * 143.4;
                        break;
                    default:
                        break;
                }
                return result;
            }
            else if (currencyFrom == "GBP")
            {
                switch (currencyTo)
                {
                    case "EUR":
                        result = currencyAmount * 1.15;
                        break;
                    case "USD":
                        result = currencyAmount * 1.22;
                        break;
                    case "CNY":
                        result = currencyAmount * 8.19;
                        break;
                    case "JPY":
                        result = currencyAmount * 166.2;
                        break;
                    default:
                        break;
                }
                return result;
            }
            else if (currencyFrom == "CNY")
            {
                switch (currencyTo)
                {
                    case "EUR":
                        result = currencyAmount * 0.14;
                        break;
                    case "GBP":
                        result = currencyAmount * 0.12;
                        break;
                    case "USD":
                        result = currencyAmount * 0.14;
                        break;
                    case "JPY":
                        result = currencyAmount * 20.27;
                        break;
                    default:
                        break;
                }
                return result;
            }
            else if (currencyFrom == "JPY")
            {
                switch (currencyTo)
                {
                    case "EUR":
                        result = currencyAmount * 0.006;
                        break;
                    case "GBP":
                        result = currencyAmount * 0.006;
                        break;
                    case "CNY":
                        result = currencyAmount * 0.049;
                        break;
                    case "USD":
                        result = currencyAmount * 0.007;
                        break;
                    default:
                        break;
                }
                return result;
            }
            return result;
        }
        public class Program
        {
            internal static string currencyFrom;

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
            {"Chinese Yuan", "CNY"},
            {"Japanese Yen", "JPY"},
        };

                foreach (var currency in CurrencyList)
                {
                    Console.WriteLine($"\t{currency.Key}: {currency.Value}");
                }
                Console.WriteLine();
                
                bool endApp = false;

                while (!endApp)
                {
                    string currencyFrom;
                    string currencyTo;
                    string currencyAmount;
                    bool isCurrency = false;
                    bool isNumerical = false;
                   
                    while (!isCurrency)
                    {
                        Console.WriteLine("Enter three-letter currency code you want to convert FROM: ");
                        currencyFrom = Console.ReadLine();

                        Console.WriteLine();

                        Console.WriteLine("Enter three-letter currency code you want to convert TO: ");
                        currencyTo = Console.ReadLine();

                        if (!CurrencyList.ContainsValue(currencyFrom) || !CurrencyList.ContainsValue(currencyTo))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Please enter a currency code listed above and in ALL-CAPS!");
                            Console.WriteLine();
                        }
                        else
                        {
                            isCurrency = true;
                            while (!isNumerical)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Enter numerical amount you want to convert: ");
                                currencyAmount = Console.ReadLine();
                                //double currencyAmountTemp = Convert.ToDouble(Console.ReadLine());
                                if (!double.TryParse(currencyAmount, out double value))
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Enter a number, Pinhead.");
                                }
                                else
                                {
                                    isNumerical = true;
                                    Console.WriteLine();
                                    Console.WriteLine("Approx: " + ConvertCurrency(currencyFrom, currencyTo, Convert.ToDouble(currencyAmount)) + $" {currencyTo}");
                                }
                            }

                        }

                    }
                    Console.WriteLine();
                    Console.Write("Press 'q' and Enter to close the app, or press any other key and Enter to continue: ");
                    if (Console.ReadLine() == "q") endApp = true;

                }
                return;
            }
        }
    }
}
