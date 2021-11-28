using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    internal class Program
    {
        static long Fib(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Fib(2)="+Fib(2));
            Console.WriteLine("Fib(3)=" + Fib(3));
            Console.WriteLine("Fib(4)=" + Fib(4));
            Console.WriteLine("Fib(5)=" + Fib(5));
            Console.WriteLine("Fib(6)=" + Fib(6));
            Console.WriteLine("Fib(7)=" + Fib(7));
            Console.WriteLine("Fib(8)="+Fib(8));
            Console.WriteLine("Fib(9)="+Fib(9));
            Console.WriteLine("Fib(10)="+Fib(10));
        }
    }
}
