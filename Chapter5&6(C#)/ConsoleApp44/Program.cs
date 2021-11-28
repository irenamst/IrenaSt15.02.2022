using System;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = 100;
            uint Fact(uint n)
            {
                if (n == 1)
                {
                    return 1;
                }
                return n*Fact(n - 1);
                
            }
            Console.WriteLine(Fact(n));
        }
    }
}
