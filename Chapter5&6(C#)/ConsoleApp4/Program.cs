using System;
using System.Globalization;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int h;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("S="+((a+b)*h)/2);
        }
    }
}
