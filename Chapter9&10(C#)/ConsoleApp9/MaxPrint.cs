using System;

namespace ConsoleApp9
{
    class MaxPrint
    {
        static void PrintMax(float number1, float number2)
        {
            float max = number1;
            if (number2 > max)
            {
                max = number2;
            }
            Console.WriteLine("max: " + max);
        }

        static void Main(string[] args)
        {
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            PrintMax(num1, num2);
        }
    }
}
