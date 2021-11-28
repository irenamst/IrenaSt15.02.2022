using System;

namespace ConsoleApp69
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a hexiDecimal number:");
            string hexDecimal = Console.ReadLine();
            int num = Convert.ToInt32(hexDecimal, 16);
            Console.WriteLine(num);

        }
    }
}
