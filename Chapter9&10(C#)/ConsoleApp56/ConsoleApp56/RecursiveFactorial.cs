using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    internal class RecursiveFactorial
    {
        static decimal Factorial (int n)
        {
            //The bottom of the resursion
            if (n == 0)
            {
                return 1;
            }
            //Recursive call: the method class itself
            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("n=");
            int n=int.Parse(Console.ReadLine());
            decimal factorial=Factorial(n);
            Console.WriteLine("{0}!={1}", n, factorial);
            if (n >= 20000000)
            {
                //Stack overflow exception
                throw new Exception("Absurt!");
            }
            if (n <0)
            {
                //Stack overflow exception
                throw new Exception("Absurt!");
            }
        }
    }
}
