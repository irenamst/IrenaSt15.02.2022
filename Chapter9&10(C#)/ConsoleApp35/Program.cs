using System;

namespace ConsoleApp35
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 17;
            void PrintAgeAfter(int years)
            {
                Console.WriteLine(age + years);
            }
            PrintAgeAfter(3);
        }
    }
}
