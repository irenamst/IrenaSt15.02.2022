using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    internal class Program
    {
        static decimal Factorial(int n)
        {
            //the bottom of the recursion
            if (n == 0)
            {
                return 1;
            }
            //Recursive call:the method calls itself
            else
            {
                return n * Factorial(n-1);
            }
        }
        static void Main(string[] args)
        {
            int n = -1;
            Console.WriteLine("({0})!={1}",n,Factorial(n));
            if (Factorial(0) != 1)
            {
                throw new Exception("Функцията на е дефирана за n=0.");
            }
            if(Factorial(1) != 1)
            {
                throw new Exception("Функцията не е дефинирана за n=1.");
            }
            if (n >= int.MaxValue)
            {
                throw new Exception("Препълване");
            }
            if (n < 0)
            {
                throw new Exception("Функцията не e дефинирана.");
            }
        }
    }
}
