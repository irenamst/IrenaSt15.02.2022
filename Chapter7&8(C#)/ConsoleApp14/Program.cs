using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n =int.Parse(Console.ReadLine());
            Console.Write("k= ");
            int k = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int bestSum = int.MinValue;
            int bestIndex = 0;
            for(int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = i; j < k; j++)
                {
                    sum = sum + a[j];
                }
                if(sum>bestSum)
                {
                    bestSum = sum;
                    bestIndex = i;
                }
            }
            for(int i = bestIndex; i < k; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("The maximal sum is: {0}", bestSum);
        }
    }
}
