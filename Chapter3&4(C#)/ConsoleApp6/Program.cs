using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            int count = 0;
            int[] a = new int[m - n + 1];
            for (int i = 0; i < m - n+1; i++) {
                a[i] = 0;
                if ((i + n) % 5 == 0)
                {
                    a[i] = 1;
                    count++;
                }
            }
            
            Console.WriteLine("There are "+count+" numbers:");
            for (int i = 0; i < m-n+1; i++) {
                if(a[i]==1)
                Console.Write(i+n + ", ");
            }
        }
    }
}
