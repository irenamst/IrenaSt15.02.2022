using System;

namespace ConsoleApp18
{
    class SumPrices
    {
        static void PrintTotalAmountForBooks(decimal[] prices)
        {
            decimal totalAmount = 0;
            foreach (decimal singlePriceForBook in prices)
            {
                totalAmount = totalAmount + singlePriceForBook;
            }
            Console.WriteLine("The total amount of all books is: " + totalAmount);
        }
        static void Main(params string[] args)
        {
            decimal[] prices = new decimal[] { 3m, 2.5m };
            PrintTotalAmountForBooks(prices);
        }
    }
}
