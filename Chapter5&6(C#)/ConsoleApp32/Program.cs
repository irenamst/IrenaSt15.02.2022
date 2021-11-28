using System;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m= ");
            int m = int.Parse(Console.ReadLine());
            for (int num = n; num <= m; num++) {
                ////////////////////////////////////////////
                bool prime = true;
                int maxDivider = (int)Math.Sqrt(num);
                for (int d=2; d<=maxDivider; d++) {
                    if (num % d == 0) {
                        prime = false;
                        break;
                    }
                }
                if (prime) {
                    Console.Write(num + " ");
                }
            }
            
        }
    }
}
