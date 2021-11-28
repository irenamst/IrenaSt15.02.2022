using System;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                int x = b;
                b = a;
                a = x;
                Console.WriteLine("The first number is bigger than the second.");
                Console.WriteLine("first:" + a + ", second: " + b);
            }
            
        }
    }
}
