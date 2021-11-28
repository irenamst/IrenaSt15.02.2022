using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radios of a circle:");
            double r = double.Parse(Console.ReadLine());
            double perimeter = (double) 2 * Math.PI * r;
            double surface = (double)Math.PI * r * r;
            Console.WriteLine("P=" + perimeter);
            Console.WriteLine("S=" + surface);
        }
    }
}
