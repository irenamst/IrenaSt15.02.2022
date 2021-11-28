using System;
using System.Numerics;

namespace std { };
class Factorial
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        do
        {
            factorial *= n;
            n--;
        } while (n > 0);
        Console.WriteLine("n! = " + factorial);
    }
}