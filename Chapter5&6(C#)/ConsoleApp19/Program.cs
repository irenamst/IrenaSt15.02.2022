using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a positive number: ");
            int num = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDiveder = (int)Math.Sqrt(num);
            bool prime = true;
            while (prime && (divider <=maxDiveder)) {
                if ((num % divider)==0) {
                    prime = false;
                }
                divider++;
            }
            Console.WriteLine("Is num prime ? " + prime);
        }
    }
}
