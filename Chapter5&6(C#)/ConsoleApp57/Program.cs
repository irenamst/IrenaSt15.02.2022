using System;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            uint n = uint.Parse(Console.ReadLine());
            uint a0 = 0;
            uint a1 = 1;
            Console.Write(a0 + " ");
            Console.Write(a1 + " ");
            for(uint i=1; i < n; i++)
            {
                uint a2 = a1 + a0;
                Console.Write(a2 + " ");
                a0 = a1;
                a1 = a2;
            }

        }
    }
}
