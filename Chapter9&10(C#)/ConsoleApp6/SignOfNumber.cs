using System;

namespace ConsoleApp6
{
    class SignOfNumber
    {
        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
        static void Main(string[] args)
        {
            int number1 = 3;
            int number2 = -3;
            int zero = 0;
            PrintSign(number1);
            PrintSign(number2);
            PrintSign(zero);
        }
    }
}
