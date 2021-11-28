using System;

namespace ConsoleApp12
{
    class PrSign
    {
        static void PrintSign(int intValue)
        {
            if (intValue > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (intValue < 0)
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
            PrintSign(2 + 2);
            float oldQuantity = 3;
            float quantity = 2;

        }
    }
}
