using System;

namespace ConsoleApp61
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            uint n = uint.Parse(Console.ReadLine());
            uint Product = 1;
            for(uint i = 1; i <= n; i++)
            {
                Product = Product* (n + i) / i;
            }
            Product = Product / (n + 1);
            Console.WriteLine("(2n)!/((n+1)!*n!)= "+Product);
        }
    }
}
