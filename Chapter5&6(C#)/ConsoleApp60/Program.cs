using System;

namespace ConsoleApp60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            uint n = uint.Parse(Console.ReadLine());
            Console.Write("k= ");
            uint k = uint.Parse(Console.ReadLine());
            uint Product = 1;
            
            for(uint i = 1; i <= k; i++)
            {
                Product = Product * (n-k+i)/i;
            }
            Console.WriteLine("n!/((n-k)!*k!)= " + Product);
        }
    }
}
