using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int small = 1, large = 10; small < large; small++, large--)
            {
                Console.WriteLine(small + " " + large);
            }

        }
    }
}
