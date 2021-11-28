using System;

namespace ConsoleApp13
{
    class Program
    {
        static int Fibonachi(int n)
        {
            if (n < 0)
            {
                return -1;
            }
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1; 
            }
            
        
            return Fibonachi(n - 1) + Fibonachi(n - 2);

        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n;
            bool success = Int32.TryParse(str, out n);
            if (success)
            {
                for(int i=0; i <= n; i++)
                {
                    Console.WriteLine(Fibonachi(i)+" ");
                }
                 
            }
        }
    }
}
