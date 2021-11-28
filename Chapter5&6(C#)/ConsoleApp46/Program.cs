using System;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("n= ");
            n = int.Parse(Console.ReadLine());
            int[] a= new int[n];
            int[] b = new int[n];
            for(int i=0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            };
            for (int i = 0; i < b.Length; i++) {
                b[i] = int.Parse(Console.ReadLine());
            };
            bool flag = true;
            for (int i = 0; i < a.Length && flag; i++) {
                if (a[i] != b[i]) {
                    flag = false;
                }
            }
            Console.WriteLine(flag);

        }
    }
}
