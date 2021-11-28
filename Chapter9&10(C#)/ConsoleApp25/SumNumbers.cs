using System;

namespace ConsoleApp25
{
    class SumNumbers
    {
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static long Sum2(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(2, 3));
            //overload
        }
    }
}
