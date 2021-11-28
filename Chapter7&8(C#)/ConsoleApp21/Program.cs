using System;

namespace ConsoleApp21
{
    class Program
    {
        static void PrintNumber(int numberPar)
        {
            numberPar = 5;
            Console.WriteLine("In the PrintNumber() method after the modification numberPar is {0}:",numberPar);
        }
        static void Main(string[] args)
        {
            int numberArg = 3;
            PrintNumber(numberArg);
            Console.WriteLine("In the main method numberArg is {0}", numberArg);
        }
    }
}
