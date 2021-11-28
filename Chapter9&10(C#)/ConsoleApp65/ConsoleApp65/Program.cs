using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp65
{
    internal class Program
    {
        static long Fib(int n)
        {
            long fn = 1;
            long fnMinus1 = 1;
            long fnMinus2 = 1;
            for(int i = 2; i < n; i++)
            {
                fn = fnMinus1 + fnMinus2;
                fnMinus2=fnMinus1;
                fnMinus1 = fn;
            }
            return fn;
        }
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n=int.Parse(Console.ReadLine());
            long result = Fib(n);
            Console.WriteLine("fib({0})={1}", n, result);
        }
    }
}
