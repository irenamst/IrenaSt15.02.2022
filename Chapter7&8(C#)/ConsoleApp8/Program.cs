using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] capitals = { "Sofia", "Washington", "London", "Paris" };
            foreach(string capital in capitals)
            {
                Console.Write(capital + " ");
            }
        }
    }
}
