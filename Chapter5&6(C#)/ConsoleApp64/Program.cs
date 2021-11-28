using System;

namespace ConsoleApp64
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            uint n = uint.Parse(Console.ReadLine());
            Console.WriteLine(n);
           
            double factoriel(uint n)
            {
                double fact = 1;
                for(uint i=2; i<=n; i++)
                {
                    fact = fact * i;
                }
                return fact;
            }
            uint Zeros(uint n)
            {
                uint a = 1;
                for(uint i=0; i<=n; i++)
                {
                    a = i / 5;
                }
                return a;
            }
            //Console.WriteLine(fact);//6 227 020 800
            Console.WriteLine("N!=" + factoriel(n) + "->" + Zeros(n));
        }
    }
}
