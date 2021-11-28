using System;

namespace ConsoleApp42
{
    class Program
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
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonachi(n)="+Fib(n));
        }
    }
}
