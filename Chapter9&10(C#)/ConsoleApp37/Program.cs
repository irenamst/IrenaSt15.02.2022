using System;

namespace ConsoleApp37
{
    class Program
    {
        static int Add(double number1,double number2)
        {
            return (int)(number1 + number2);
        }
        static double Add1(double number1,double number2)
        {
            return (number1 + number2);
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            int sum = Add(a, b);
            Console.WriteLine(sum);
            double sum1 = Add1(a, b);
            Console.WriteLine(sum1);
        }
    }
}
