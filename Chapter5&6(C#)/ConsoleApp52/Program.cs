using System;

namespace ConsoleApp52
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i <= n; i++)
            {
                if (i % 3!=0 && i % 7!=0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
