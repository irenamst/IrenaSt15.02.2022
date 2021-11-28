using System;

namespace ConsoleApp55
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("n= ");
            uint n = uint.Parse(Console.ReadLine());
            static uint factoriel(uint n)
            {
                
                if (n == 0 || n == 1)
                    return  1;
                return n * factoriel(n - 1);

            }
            Console.WriteLine(factoriel(n));
        }
    }
}
