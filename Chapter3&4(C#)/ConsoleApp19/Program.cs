using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = ((2 < 3) && (5 > 4));
            Console.WriteLine(result);
            result = ((2 < 3) || (5 > 4));
            Console.WriteLine(result);
        }
    }
}
