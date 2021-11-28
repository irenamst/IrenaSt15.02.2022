using System;

namespace ConsoleApp28
{
    class Program
    {
        static float Multiply(float number1, float number2)
        {
            float result = number1 * number2;
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("number1=");
            float number1 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("number2=");
            float number2 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            float multiply = Multiply(number1, number2);
            Console.WriteLine(multiply);
        }
    }
}
