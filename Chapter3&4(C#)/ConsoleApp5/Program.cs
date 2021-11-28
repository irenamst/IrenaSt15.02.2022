using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0,-10:X}{1,-10:X}", 94,64);
            Console.WriteLine("{0,-10:F}{1,-10:F}", 94.5, 64.5);
            Console.WriteLine("{0,-10:F}{1,-10:F}", -94.5, -64.5);
        }
    }
}
