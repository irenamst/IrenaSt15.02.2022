﻿using System;

namespace ConsoleApp43
{
    class RecursiveFactorial
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            decimal factorial = Factorial(n);
            Console.WriteLine("{0}!={1}",n,factorial);
        }
        static decimal Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
