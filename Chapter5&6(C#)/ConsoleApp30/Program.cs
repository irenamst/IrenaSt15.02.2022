using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,4,5,6,7,8,9 };
            foreach (int i in numbers) {
                Console.Write(" "+i);
            }
            Console.WriteLine();
            String[] towns = { "Sofia", "Varna", "Plovdiv", "Burgas" };
            foreach (string town in towns) {
                Console.Write(" " + town);
            }

        }
    }
}
