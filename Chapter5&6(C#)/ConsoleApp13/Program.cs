using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = (2 < 3) && (3 < 4);
            bool result2 = (2 < 3) || (1 == 2);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine("Exclusive OR: " + ((2 < 3) ^ (4 > 3))); //False
            bool value = !(7 == 5); // Тrue
            Console.WriteLine(value);

        }
    }
}
