using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    internal class Program
    {
        static decimal Factorial(int n)
        {
            decimal result = 1;
            for (int i = 1; i < n+1; i++)
            {
                result =result* i;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            decimal factorial = Factorial(n);
            Console.WriteLine(factorial);
        }
    }
}
