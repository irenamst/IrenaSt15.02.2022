using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1, sum = 1; i <= 128; i = i * 2, sum += i)
            {
                Console.WriteLine("i={0}, sum={1}", i, sum);
            }
        }
    }
}
