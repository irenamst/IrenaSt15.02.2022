using System;

namespace ConsoleApp66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            string binaryNum = Convert.ToString(num, 2);
            Console.WriteLine(binaryNum);
        }
    }
}
