using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 2;
            int num2 = 1;
            if (num1 == num2)
            {
                Console.WriteLine("The numbers are equal.");
            }
            else
            {
                if (num1 > num2)
                {
                    Console.WriteLine("The number1 is greater than number2");
                }
                else
                {
                    Console.WriteLine("The number2 is greater than number1");
;                }
            }
        }
    }
}
