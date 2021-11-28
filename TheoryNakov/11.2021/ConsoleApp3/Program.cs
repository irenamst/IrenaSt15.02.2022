using System;

namespace ConsoleApp3
{
    class Program
    {
        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        }
        static void Main(string[] args)
        {
            Console.Write("num1=");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("num2=");
            int num2 = int.Parse(Console.ReadLine());
            int multiply = Multiply(num1, num2);
            Console.WriteLine("multiply="+multiply);
        }
    }
}
