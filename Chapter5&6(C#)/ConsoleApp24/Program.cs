using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            int num = n;
            long product = 1;
            do
            {
                product *= num;
                num++;
            }
            while (num <= m);
            Console.WriteLine("Product[n..m]=" + product);
        }
    }
}
