using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 7;
            switch (number)
            {
                case 0:
                case 1:
                case 4:
                case 6:
                case 8:
                case 9: 
                    Console.WriteLine("The number is not prime.");
                    break;
                case 2:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("The number is prime.");
                    break;
                default:
                    Console.WriteLine("The number is unknown.");
                    break;
            }
        }
    }
}
