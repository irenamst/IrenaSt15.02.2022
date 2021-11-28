using System;

namespace ConsoleApp68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number:");
            int num = int.Parse(Console.ReadLine());
            string hexDecimal = Convert.ToString(num, 16);
            Console.WriteLine(hexDecimal);
        }
    }
}
