using System;

namespace ConsoleApp15
{
    class SumPrices
    {
        static void PrintTotalAmountForBooks(params decimal[] prices)
        {
            decimal totalAmount = 0;
            foreach (decimal singleBookPrice in prices)
            {
                totalAmount += singleBookPrice;
            }
            Console.WriteLine("Total Amount of the prices of the books: " + totalAmount);
        }
        static void Main(string[] args)
        {
            decimal[] prices = new decimal[] { 3m, 2.5m };
            PrintTotalAmountForBooks(prices);
            PrintTotalAmountForBooks(3m, 2.5m);
            PrintTotalAmountForBooks(3m, 5.1m, 10m, 4.5m);
        }
    }
}
