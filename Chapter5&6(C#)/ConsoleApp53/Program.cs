using System;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int [] a = new int [n];
            for(int i=0; i <a.Length; i++)
            {
                Console.Write("a_{" + i + "}=");
                a[i] = int.Parse(Console.ReadLine());
            }
            int min=a[0];
            int max=a[0];
            for(int i=1; i<a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine("a_{min}=" + min + " ,a_{max}=" + max);
        }
    }
}
