using System;

namespace ConsoleApp47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n;
            n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            int m;
            m = int.Parse(Console.ReadLine());
            int[] a = new int[m];
            for (int s = 0; s < m; s++) {
                a[s] = 1;
            }

            for(int i = 2; i < m; i++)
            {
                for(int k = i + 1; k < m; k++)
                {
                    if (k % i == 0)
                    {
                        a[k] = 0;
                    }
                }
            }
            for (int j = n; j < m; j++) {
                if (a[j]==1) {
                    Console.Write(j + " ");
                }
            }
        }
    }
}
