using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers:");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());
            if (a > b && b > c)
            {
                Console.WriteLine("{0},{1},{2}", a, b, c);
            }
            else if (a > c && c > b)
            {
                Console.WriteLine("{0},{2},{1}", a, b, c);
            } 
            else if (b > a && a > c)
            {
                Console.WriteLine("{1},{0},{2}", a, b, c);
            } 
            else if (b > c && c > a)
            {
                Console.WriteLine("{1},{2},{0}", a, b, c);
            } 
            else if (c > a && a > b)
            {
                Console.WriteLine("{2},{0},{1}", c, a, b);
            } 
            else if (c > b && b > a)
            {
                Console.WriteLine("{2},{1},{0}", c, b, a);
            } 
            
        }
    }
}
