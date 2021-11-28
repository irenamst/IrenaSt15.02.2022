using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            int min = (n+m - Math.Abs(n-m)) / 2;
            int max = (n+m + Math.Abs(n-m)) / 2;
            Console.WriteLine("The smaller is " + min);
            Console.WriteLine("The larger is " + max);
        }
    }
}
