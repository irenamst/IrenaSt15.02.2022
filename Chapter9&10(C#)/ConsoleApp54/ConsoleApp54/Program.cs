using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class Program
    {
        static decimal Factorial(int n)
        {
            //The bottom of the resursion
            if (n == 0)
            {
                return 1;
            }
            //Recursive call: the method calls itself
            else
            {
                return n * Factorial(n - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("0!="+Factorial(0));
            Console.WriteLine("1!=" + Factorial(1));
            Console.WriteLine("2!=" + Factorial(2));
            Console.WriteLine("3!=" + Factorial(3));
            Console.WriteLine("4!=" + Factorial(4));
            Console.WriteLine("5!=" + Factorial(5));
        }
    }
}
