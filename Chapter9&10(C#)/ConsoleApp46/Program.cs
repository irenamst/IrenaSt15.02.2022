using System;

namespace ConsoleApp46
{
    class Program
    {
        static decimal Factorial(int n)
        {
            decimal result=0;
            if(n == 0)
            {
                result = 1;
            }
            else
            {
                result = n * Factorial(n-1) ;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.Readline());
        }
    }
}
