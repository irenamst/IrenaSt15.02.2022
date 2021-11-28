using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 35;
            int p = 5;
            int v = 0;
            int i = 1;
            int mask = i << p;
            Console.WriteLine((n&mask)!=v );
        }
    }
}
