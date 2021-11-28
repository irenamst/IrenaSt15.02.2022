using System;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] boi = { "Kupa", "Spatiq", "Karo" , "Pika" };
            string[] num = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "D", "K", "A" };
            foreach (string boq in boi) {
                foreach (string number in num) {
                    Console.Write(number + " " + boq + ", ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
