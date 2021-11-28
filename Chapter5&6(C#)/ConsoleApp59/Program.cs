using System;

namespace ConsoleApp59
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("K=");
            int K = int.Parse(Console.ReadLine());
            Console.Write("N=");
            int N = int.Parse(Console.ReadLine());
            long factK = 1;
            for (int i=2;i<=K;i++)
            {
                factK = factK * 1;
            }
            long factN = factK; ;
            for(int i=K+1; i <= N; i++)
            {
                factN = factN * i;
            }
            Console.Write("N!/K! = " + factN / factK);
        }
    }
}
