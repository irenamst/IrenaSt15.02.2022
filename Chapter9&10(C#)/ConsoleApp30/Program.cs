using System;

namespace ConsoleApp30
{
    class Program
    {
        static int Add(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("num1=");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("num2=");
            int num2 = int.Parse(Console.ReadLine());
            int add = Add(num1, num2);
            Console.WriteLine("Sum=" + add);
        }
    }
}
