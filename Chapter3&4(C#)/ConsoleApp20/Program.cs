using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((2<3)^(5>4));
            bool value = !((2 < 3) && (5 > 4));
            Console.WriteLine(value);
        }
    }
}
