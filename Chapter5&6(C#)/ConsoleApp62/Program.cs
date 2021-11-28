using System;

namespace ConsoleApp62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            uint n = uint.Parse(Console.ReadLine());
            Console.Write("x= ");
            double x = double.Parse(Console.ReadLine());
            double sum = 1;
            uint factoriel(uint n) {
                uint fact = 1;
                for (uint i = 1; i <= n; i++) {
                    fact = fact * i;
                }
                return fact;
            }
            double xPow = 1;
            for (uint i = 1; i <= n; i++) {
                xPow = xPow * x;
                sum = sum + factoriel(i) / xPow;
            }
            Console.WriteLine("Sum= "+sum);
        }
    }
}
