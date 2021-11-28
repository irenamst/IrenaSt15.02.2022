using System;
using System.Numerics;
namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            while (n > 1)
            {
                factorial *= n;
                n--;
            }
            Console.WriteLine("n! = " + factorial);

        }
    }
}
