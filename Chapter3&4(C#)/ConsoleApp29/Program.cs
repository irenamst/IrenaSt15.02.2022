using System;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.Write("Max:"+" ");
            if(a>b && a > c)
            {
                Console.Write(a);
            }else if(b > a && b > c)
            {
                Console.Write(b);
            }else if(c > a && c > b)
            {
                Console.Write(c);
            }
        }
    }
}
