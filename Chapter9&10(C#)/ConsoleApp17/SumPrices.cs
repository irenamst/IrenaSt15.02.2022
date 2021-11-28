using System;

namespace ConsoleApp17
{
    class SumPrices
    {
        static void PrintTotalAmountForBooks(params decimal[] prices)
        {
            decimal totalAmount = 0;
            foreach (decimal singleBookPrice in prices)
            {
                totalAmount = totalAmount + singleBookPrice;
            }
            Console.WriteLine("The total amount of all books is: " + totalAmount);
        }
        static void Main(string[] args)
        {
            decimal[] prices = new decimal[] { 3m, 2.5m };
            PrintTotalAmountForBooks(prices);
            PrintTotalAmountForBooks(3m, 2.5m);
            PrintTotalAmountForBooks(3m, 5.1m, 10m, 4, 5m);
            PrintTotalAmountForBooks();
        }
    }
}
