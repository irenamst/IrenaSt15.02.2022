using System;

namespace ConsoleApp5
{
    class PrintTotalAmount
    {
        static void PrintTotalAmountForBooks(decimal[] prices)
        {
            decimal totalAmount = 0;
            foreach (decimal singleBookPrice in prices)
            {
                totalAmount += singleBookPrice;
            }
            Console.WriteLine("The total amount of all books is: " + totalAmount);
        }
        static void Main(string[] args)
        {
            decimal[] prices = { 10, 20, 30, 20, 50, 30, 10, 25, 13, 30 };
            PrintTotalAmountForBooks(prices);
        }
    }
}
