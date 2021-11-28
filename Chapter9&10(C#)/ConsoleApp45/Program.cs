using System;

namespace ConsoleApp45
{
    class Program
    {
        static decimal Factorial(int n)
        {
            decimal factorial = 1;
            for(int i=1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            decimal factorialN = Factorial(n);
            Console.WriteLine("{0}!={1}",n,factorialN);
        }
    }
}
