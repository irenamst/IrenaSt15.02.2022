using System;

namespace ConsoleApp24
{
    class OverLoadMethod
    {
        static void PrintNumbers(int intValue, float floatValue)
        {
            Console.WriteLine(intValue + " ; " + floatValue);
        }
        static void PrintNumbers(float floatValue, int intValue)
        {
            Console.WriteLine(floatValue + " ; " + intValue);
        }
        static void Main(string[] args)
        {
            PrintNumbers(2.71f, 2);
            PrintNumbers(5, 3.14159f);
            PrintNumbers((float)2, (short)3);
        }
    }
}
