using System;

namespace ConsoleApp13
{
    class SumPrices
    {
        static void PrintTotalAmountForBooks(params decimal[] prices)
        {
            decimal totalAmount = 0; ;
            foreach (decimal singleBookPrice in prices)
            {
                totalAmount += singleBookPrice;
            }
            Console.WriteLine("The total amount of the prices of the books is: " + totalAmount);
        }
        static void Main(string[] args)
        {
            decimal[] prices = new decimal[] { 3m, 2.5m };
            PrintTotalAmountForBooks(prices);
            PrintTotalAmountForBooks(2m, 2.5m);
            PrintTotalAmountForBooks(2m, 2.5m, 3m, 3.5m, 5.1m);

        }
    }
}
