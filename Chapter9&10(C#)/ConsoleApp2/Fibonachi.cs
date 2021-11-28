using System;

namespace ConsoleApp2
{
    class Fibonachi
    {
        static long Fib(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }
        static void Main(string[] args)
        {
            int n = 5;
            for (int i = 1; i <= n; ++i)
                Console.WriteLine(Fib(i) + " ");
        }
    }
}
