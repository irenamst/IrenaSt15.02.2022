using System;

namespace ConsoleApp7
{
    class MaxNum
    {
        static void PrintMax(float number1, float number2)
        {
            float max = number1;
            if (number2 > max)
            {
                max = number2;
            }
            Console.WriteLine(max);
        }
        static void Main(string[] args)
        {
            float number1 = 1.2f;
            float number2 = 3.4f;
            PrintMax(number1, number2);
        }
    }
}
