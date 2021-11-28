using System;

namespace ConsoleApp22
{
    class Program
    {
        static void PrintMax(float x,float y)
        {
            float max = x;
            if (y > max)
            {
                max = y;
            }
            Console.WriteLine("The max number is: {0}", max);
        }
        static void Main(string[] args)
        {
            float a = 4.5f;
            float b = 3.4f;
            PrintMax(a, b);
        }
    }
}
