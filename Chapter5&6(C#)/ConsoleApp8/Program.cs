using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please write your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please write your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Your name is {0} {1}.", firstName, lastName);
        }
    }
}
