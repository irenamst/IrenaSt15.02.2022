using System;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
           // Console.WriteLine();
            Console.Write("The sum is "+sum);
            for (int i = 1; i <= n; i += 2)
            {
                if (i % 7 == 0)
                {
                    continue;
                }
                sum += i;
                Console.Write(" + "+ i);
            }
            Console.WriteLine(" = " + sum);
        }
    }
}
