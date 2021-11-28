using System;

namespace ConsoleApp6
{
    class Program
    {
        static void PrintPositiveNumber(int number)
        {
            if(number<=0)
            {
                return;
            }
            Console.WriteLine(number);
        }
        static int CompareTo(int number1, int number2)
        {
            if (number1 > number2)
            {
                return 1;
            }
            else if (number1 == number2)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("num1=");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("num2=");
            int num2 = int.Parse(Console.ReadLine());
            int compare = CompareTo(num1, num2);
            Console.WriteLine(compare);
            PrintPositiveNumber(num1);
        }
    }
}
