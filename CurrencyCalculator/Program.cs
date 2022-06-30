using System;
using System.Collections;
using System.Linq;

namespace FinalProject
{
    public class CurrencyCalculator
    {
        public static double ConvertCurrency(string currencyFrom, string currencyTo, double currencyAmount)
        {   //method to calculate currency conversion
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
                    case "AUD":
                        result = currencyAmount * 1.45;
                        break;
                    case "CAD":
                        result = currencyAmount * 1.28;
                        break;
                    case "CHF":
                        result = currencyAmount * 0.95;
                        break;
                    case "SEK":
                        result = currencyAmount * 10.18;
                        break;
                    case "RUB":
                        result = currencyAmount * 52.62;
                        break;
                    case "HKD":
                        result = currencyAmount * 7.84;
                        break;
                    case "INR":
                        result = currencyAmount * 78.73;
                        break;
                    case "THB":
                        result = currencyAmount * 35.1;
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
                    case "AUD":
                        result = currencyAmount * 1.52;
                        break;
                    case "CAD":
                        result = currencyAmount * 1.35;
                        break;
                    case "CHF":
                        result = currencyAmount * 1;
                        break;
                    case "SEK":
                        result = currencyAmount * 10.68;
                        break;
                    case "RUB":
                        result = currencyAmount * 55.19;
                        break;
                    case "HKD":
                        result = currencyAmount * 8.23;
                        break;
                    case "INR":
                        result = currencyAmount * 82.58;
                        break;
                    case "THB":
                        result = currencyAmount * 36.82;
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
                    case "AUD":
                        result = currencyAmount * 1.76;
                        break;
                    case "CAD":
                        result = currencyAmount * 1.56;
                        break;
                    case "CHF":
                        result = currencyAmount * 1.16;
                        break;
                    case "SEK":
                        result = currencyAmount * 12.38;
                        break;
                    case "RUB":
                        result = currencyAmount * 63.98;
                        break;
                    case "HKD":
                        result = currencyAmount * 9.54;
                        break;
                    case "INR":
                        result = currencyAmount * 95.73;
                        break;
                    case "THB":
                        result = currencyAmount * 42.68;
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
                    case "AUD":
                        result = currencyAmount * 0.21;
                        break;
                    case "CAD":
                        result = currencyAmount * 0.19;
                        break;
                    case "CHF":
                        result = currencyAmount * 0.14;
                        break;
                    case "SEK":
                        result = currencyAmount * 1.51;
                        break;
                    case "RUB":
                        result = currencyAmount * 7.85;
                        break;
                    case "HKD":
                        result = currencyAmount * 1.17;
                        break;
                    case "INR":
                        result = currencyAmount * 11.74;
                        break;
                    case "THB":
                        result = currencyAmount * 5.23;
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
                    case "AUD":
                        result = currencyAmount * 0.01;
                        break;
                    case "CAD":
                        result = currencyAmount * 0.009;
                        break;
                    case "CHF":
                        result = currencyAmount * 0.007;
                        break;
                    case "SEK":
                        result = currencyAmount * 0.074;
                        break;
                    case "RUB":
                        result = currencyAmount * 0.38;
                        break;
                    case "HKD":
                        result = currencyAmount * 0.057;
                        break;
                    case "INR":
                        result = currencyAmount * 0.577;
                        break;
                    case "THB":
                        result = currencyAmount * 0.25;
                        break;
                    default:
                        break;
                }
                return result;
            }
            else if (currencyFrom == "AUD")
            {
                switch (currencyTo)
                {
                    case "EUR":
                        result = currencyAmount * 0.65;
                        break;
                    case "GBP":
                        result = currencyAmount * 0.56;
                        break;
                    case "USD":
                        result = currencyAmount * 0.68;
                        break;
                    case "CNY":
                        result = currencyAmount * 4.61;
                        break;
                    case "JPY":
                        result = currencyAmount * 93.92;
                        break;
                    case "CAD":
                        result = currencyAmount * 0.88;
                        break;
                    case "CHF":
                        result = currencyAmount * 0.65;
                        break;
                    case "SEK":
                        result = currencyAmount * 7.01;
                        break;
                    case "RUB":
                        result = currencyAmount * 36.24;
                        break;
                    case "HKD":
                        result = currencyAmount * 5.4;
                        break;
                    case "INR":
                        result = currencyAmount * 54.22;
                        break;
                    case "THB":
                        result = currencyAmount * 24.18;
                        break;
                    default:
                        break;
                }
                return result;
            }
            else if (currencyFrom == "CAD")
            {
                switch (currencyTo)
                {
                    case "EUR":
                        result = currencyAmount * 0.74;
                        break;
                    case "GBP":
                        result = currencyAmount * 0.63;
                        break;
                    case "USD":
                        result = currencyAmount * 0.77;
                        break;
                    case "CNY":
                        result = currencyAmount * 5.20;
                        break;
                    case "JPY":
                        result = currencyAmount * 105.89;
                        break;
                    case "AUD":
                        result = currencyAmount * 1.12;
                        break;
                    case "CHF":
                        result = currencyAmount * 0.74;
                        break;
                    case "SEK":
                        result = currencyAmount * 7.9;
                        break;
                    case "RUB":
                        result = currencyAmount * 40.86;
                        break;
                    case "HKD":
                        result = currencyAmount * 6.09;
                        break;
                    case "INR":
                        result = currencyAmount * 61.14;
                        break;
                    case "THB":
                        result = currencyAmount * 27.26;
                        break;
                    default:
                        break;
                }
                return result;
            }
            else if (currencyFrom == "CHF")
            {
                switch (currencyTo)
                {
                    case "EUR":
                        result = currencyAmount * 0.99;
                        break;
                    case "GBP":
                        result = currencyAmount * 0.86;
                        break;
                    case "USD":
                        result = currencyAmount * 1.04;
                        break;
                    case "CNY":
                        result = currencyAmount * 7.01;
                        break;
                    case "JPY":
                        result = currencyAmount * 142.83;
                        break;
                    case "CAD":
                        result = currencyAmount * 1.34;
                        break;
                    case "AUD":
                        result = currencyAmount * 1.52;
                        break;
                    case "SEK":
                        result = currencyAmount * 10.66;
                        break;
                    case "RUB":
                        result = currencyAmount * 55.11;
                        break;
                    case "HKD":
                        result = currencyAmount * 8.21;
                        break;
                    case "INR":
                        result = currencyAmount * 82.46;
                        break;
                    case "THB":
                        result = currencyAmount * 36.77;
                        break;
                    default:
                        break;
                }
                return result;
            }
            else if (currencyFrom == "SEK")
            {
                switch (currencyTo)
                {
                    case "EUR":
                        result = currencyAmount * 0.09;
                        break;
                    case "GBP":
                        result = currencyAmount * 0.08;
                        break;
                    case "USD":
                        result = currencyAmount * 0.09;
                        break;
                    case "CNY":
                        result = currencyAmount * 0.65;
                        break;
                    case "JPY":
                        result = currencyAmount * 13.38;
                        break;
                    case "CAD":
                        result = currencyAmount * 0.12;
                        break;
                    case "CHF":
                        result = currencyAmount * 0.09;
                        break;
                    case "AUD":
                        result = currencyAmount * 0.14;
                        break;
                    case "RUB":
                        result = currencyAmount * 5.16;
                        break;
                    case "HKD":
                        result = currencyAmount * 0.76;
                        break;
                    case "INR":
                        result = currencyAmount * 7.72;
                        break;
                    case "THB":
                        result = currencyAmount * 3.44;
                        break;
                    default:
                        break;
                }
                return result;
            }
            else if (currencyFrom == "RUB")
            {
                switch (currencyTo)
                {
                    case "EUR":
                        result = currencyAmount * 0.018;
                        break;
                    case "GBP":
                        result = currencyAmount * 0.015;
                        break;
                    case "USD":
                        result = currencyAmount * 0.018;
                        break;
                    case "CNY":
                        result = currencyAmount * 0.12;
                        break;
                    case "JPY":
                        result = currencyAmount * 2.58;
                        break;
                    case "CAD":
                        result = currencyAmount * 0.024;
                        break;
                    case "CHF":
                        result = currencyAmount * 0.018;
                        break;
                    case "SEK":
                        result = currencyAmount * 0.19;
                        break;
                    case "AUD":
                        result = currencyAmount * 0.02;
                        break;
                    case "HKD":
                        result = currencyAmount * 0.14;
                        break;
                    case "INR":
                        result = currencyAmount * 1.49;
                        break;
                    case "THB":
                        result = currencyAmount * 0.666;
                        break;
                    default:
                        break;
                }
                return result;
            }
            else if (currencyFrom == "HKD")
            {
                switch (currencyTo)
                {
                    case "EUR":
                        result = currencyAmount * 0.12;
                        break;
                    case "GBP":
                        result = currencyAmount * 0.10;
                        break;
                    case "USD":
                        result = currencyAmount * 0.127;
                        break;
                    case "CNY":
                        result = currencyAmount * 0.85;
                        break;
                    case "JPY":
                        result = currencyAmount * 17.37;
                        break;
                    case "CAD":
                        result = currencyAmount * 0.164;
                        break;
                    case "CHF":
                        result = currencyAmount * 0.12;
                        break;
                    case "SEK":
                        result = currencyAmount * 1.29;
                        break;
                    case "RUB":
                        result = currencyAmount * 6.7;
                        break;
                    case "AUD":
                        result = currencyAmount * 0.18;
                        break;
                    case "INR":
                        result = currencyAmount * 10.03;
                        break;
                    case "THB":
                        result = currencyAmount * 4.47;
                        break;
                    default:
                        break;
                }
                return result;
            }
            else if (currencyFrom == "INR")
            {
                switch (currencyTo)
                {
                    case "EUR":
                        result = currencyAmount * 0.01;
                        break;
                    case "GBP":
                        result = currencyAmount * 0.01;
                        break;
                    case "USD":
                        result = currencyAmount * 0.01;
                        break;
                    case "CNY":
                        result = currencyAmount * 0.08;
                        break;
                    case "JPY":
                        result = currencyAmount * 1.72;
                        break;
                    case "CAD":
                        result = currencyAmount * 0.016;
                        break;
                    case "CHF":
                        result = currencyAmount * 0.01;
                        break;
                    case "SEK":
                        result = currencyAmount * 0.12;
                        break;
                    case "RUB":
                        result = currencyAmount * 0.66;
                        break;
                    case "HKD":
                        result = currencyAmount * 0.099;
                        break;
                    case "AUD":
                        result = currencyAmount * 0.018;
                        break;
                    case "THB":
                        result = currencyAmount * 0.44;
                        break;
                    default:
                        break;
                }
                return result;
            }
            else if (currencyFrom == "THB")
            {
                switch (currencyTo)
                {
                    case "EUR":
                        result = currencyAmount * 0.02;
                        break;
                    case "GBP":
                        result = currencyAmount * 0.02;
                        break;
                    case "USD":
                        result = currencyAmount * 0.02;
                        break;
                    case "CNY":
                        result = currencyAmount * 0.19;
                        break;
                    case "JPY":
                        result = currencyAmount * 3.87;
                        break;
                    case "CAD":
                        result = currencyAmount * 0.03;
                        break;
                    case "CHF":
                        result = currencyAmount * 0.02;
                        break;
                    case "SEK":
                        result = currencyAmount * 0.28;
                        break;
                    case "RUB":
                        result = currencyAmount * 1.49;
                        break;
                    case "HKD":
                        result = currencyAmount * 0.22;
                        break;
                    case "INR":
                        result = currencyAmount * 2.23;
                        break;
                    case "AUD":
                        result = currencyAmount * 0.04;
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
            //internal static string currencyFrom;
            static void Main(string[] args)
            {
                Console.WriteLine("C# CURRENCY CALCULATOR");
                Console.WriteLine("----------------------");
                Console.WriteLine("Forex rates as of 6/29/22");
                Console.WriteLine();
                Console.WriteLine("AVAILABLE CURRENCIES:");
                Console.WriteLine();
                var CurrencyList = new Dictionary<string, string>()
        {
            {"United States Dollar", "USD"},
            {"EURO", "EUR"},
            {"British Pound Sterling", "GBP"},
            {"Australian Dollars", "AUD"},
            {"Canadian Dollars", "CAD"},
            {"Swiss Francs", "CHF"},
            {"Swedish Kronor", "SEK"},
            {"Russian Rubles", "RUB"},
            {"Chinese Yuan Renminbi", "CNY"},
            {"Hong Kong Dollar", "HKD"},
            {"Japanese Yen", "JPY"},
            {"Indian Rupees", "INR"},
            {"Thai Baht", "THB"}
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
                        Console.WriteLine();
                        Console.WriteLine("Enter three-letter currency code you want to convert FROM: ");
                        currencyFrom = Console.ReadLine().ToUpper();

                        Console.WriteLine();

                        Console.WriteLine("Enter three-letter currency code you want to convert TO: ");
                        currencyTo = Console.ReadLine().ToUpper();

                        if (!CurrencyList.ContainsValue(currencyFrom) || !CurrencyList.ContainsValue(currencyTo))
                        {
                            Console.Clear();
                            Console.WriteLine("AVAILABLE CURRENCIES:");
                            Console.WriteLine();

                            foreach (var currency in CurrencyList)
                            {
                                Console.WriteLine($"\t{currency.Key}: {currency.Value}");
                            }
                            Console.WriteLine();
                            Console.WriteLine("PLEASE ENTER A CURRENCY CODE FROM THE LIST!");
                            Console.WriteLine();
                        }
                        else if (currencyFrom == currencyTo)
                        {
                            Console.WriteLine();
                            Console.WriteLine("CANNOT CONVERT TO SELF, GENIUS. TRY AGAIN.");
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

                                if (!double.TryParse(currencyAmount, out double value1) || Double.Parse(currencyAmount) < 0)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("ENTER A POSITIVE NUMBER, PINHEAD!");
                                }
                                else
                                {
                                    isNumerical = true;
                                    Console.WriteLine();
                                    Console.WriteLine($"{currencyAmount} {currencyFrom} is approximately: "
                                    + ConvertCurrency(currencyFrom, currencyTo,
                                    Convert.ToDouble(currencyAmount)) + $" {currencyTo}");
                                }
                            }

                        }

                    }
                    Console.WriteLine();
                    Console.Write("Press 'q' and Enter to close the app, or press any other key and Enter to continue: ");
                    Console.WriteLine();
                    if (Console.ReadLine() == "q")
                    {
                        endApp = true;
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("AVAILABLE CURRENCIES:");
                        Console.WriteLine();

                        foreach (var currency in CurrencyList)
                        {
                            Console.WriteLine($"\t{currency.Key}: {currency.Value}");
                        }
                        Console.WriteLine();
                    }

                }
                return;
            }
        }
    }
}
