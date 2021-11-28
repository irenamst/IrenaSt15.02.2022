using System;

namespace ConsoleApp10
{
    class NumberPrint
    {
        static void PrintNumber(int numberParam)
        {
            numberParam = 5;
            Console.WriteLine("in PrintNumber() method after the " + "modification, number is {0}", numberParam);
        }
        static void Main(string[] args)
        {
            int numberArg = 3;
            PrintNumber(numberArg);
            Console.WriteLine("In the Main() method the arg is: " + numberArg);
        }
    }
}
