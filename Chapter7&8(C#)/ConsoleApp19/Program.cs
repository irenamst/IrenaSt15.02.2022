using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal calc = 20.4m;
            decimal result = 5.0M;
            Console.WriteLine("calc: {0}", calc);
            Console.WriteLine("result: {0}", result);
            decimal sum =0.0m;
            for(int i=0; i < 10000000; i++)
            {
                sum += 0.0000001m;
            }
            Console.WriteLine("sum= " + sum);
        }
    }
}
