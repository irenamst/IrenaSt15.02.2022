using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp64
{
    internal class Program
    {
        static long[] numbers;
        static long Fib(int n)
        {
            long result;
            if (numbers[n] == 0)
            {
                numbers[n] = Fib(n - 1) + Fib(n - 2);
            }
            result = numbers[n];
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n=int.Parse(Console.ReadLine());
            numbers=new long[n+2];
            numbers[1] = 1;
            numbers[2] = 1;
            if (n > 2 && n<2000000)
            {
                long result = Fib(n);
                Console.WriteLine("fib({0})={1}", n, result);
            }
            else if(n==1)
            {
                Console.WriteLine("fib({0})={1}",1,1);
            }else if (n == 0)
            {
                Console.WriteLine("fib({0})={1}", 0, 1);
            }
            else if(n<0)
            {
                throw new Exception("За отрицателните числа не може да се пресметне функцията на Fibonnachi");
            }
            else
            {
                throw new Exception("Не може да се пресметне за толкова големи стойности на n.");
            }
           
        }
    }
}
