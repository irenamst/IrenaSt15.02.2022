using System;

namespace ConsoleApp56
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            uint n = uint.Parse(Console.ReadLine());
            uint factoriel=1;
            for (uint i=2; i<=n; i++)
            {
                factoriel = factoriel * i;       
            }
            Console.WriteLine(factoriel);
        }
    }
}
