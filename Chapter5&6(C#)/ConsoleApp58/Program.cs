using System;

namespace ConsoleApp58
{
    class Program
    {
        static void Main(string[] args)
        {
            uint fibonachi(uint n)
            {    
                if (n == 0) return 0;
                if (n == 1) return 1;
                return fibonachi(n-1)+fibonachi(n-2);
               
            }//function

            Console.Write("n=");
            uint n = uint.Parse(Console.ReadLine());
            uint[] a = new uint[n];
            for (uint i = 0; i < n; i++) {
                a[i] = fibonachi(i);
            }
            for (uint i = 0; i < n; i++) {
                Console.Write(a[i] + " ");
            }
                     

        }
            
    }
}