using System;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            double area(int r) => Math.PI * r * r;
            double perimeter(int r) => 2 * Math.PI * r;
            Console.WriteLine(area(3));
            Console.WriteLine(perimeter(3));
        }
    }
}
