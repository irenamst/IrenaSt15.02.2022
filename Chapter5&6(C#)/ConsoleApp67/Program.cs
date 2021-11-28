using System;

namespace ConsoleApp67
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Integer number in binary system:");
            string binary = Console.ReadLine();
            int num = Convert.ToInt32(binary, 2);
            Console.WriteLine(num);
        }
    }
}
