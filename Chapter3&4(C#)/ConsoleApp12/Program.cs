using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong fibonachi(uint n)
            {
                if(n == 0)
                {
                    return 0;
                }
                if(n==1)
                {
                    return 1;
                }
                return fibonachi(n - 1) + fibonachi(n - 2);
            }
            uint n = 100;
            for(uint i = 0; i < n; i++)
            {
                Console.WriteLine(fibonachi(i) + "");
            }
            
        }
    }
}
