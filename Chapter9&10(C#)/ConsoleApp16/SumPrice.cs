using System;

namespace ConsoleApp16
{
    class SumPrices
    {
        static void PrintTotalAmountForBooks(string str, params decimal[] prices)
        {
            str = "The total amount of all books is: ";
            decimal totalAmount = 0;
            foreach (decimal singlePriceOfBook in prices)
            {
                totalAmount += singlePriceOfBook;
            }
            Console.WriteLine(str + totalAmount);
        }
        static void Main(string[] args)
        {
            string str = "The total amount of all books is: ";
            decimal[] prices = new decimal[] { 3m, 2.5m };
            PrintTotalAmountForBooks(str, prices);
            PrintTotalAmountForBooks(str, 3m, 2.4m);
            PrintTotalAmountForBooks(str, 3m, 5.1m, 10m, 4, 5m);
            PrintTotalAmountForBooks(str);

        }
    }
}
