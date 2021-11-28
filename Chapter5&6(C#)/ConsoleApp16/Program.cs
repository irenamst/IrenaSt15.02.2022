using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'X';
            if (ch == 'A' || ch == 'a') {
                Console.WriteLine("The vowel is ei");
            } else if (ch == 'E' || ch == 'e') {
                Console.WriteLine("The vowel is ee");
            } else if (ch == 'I' || ch == 'i') {
                Console.WriteLine("The vowel is ai");
            } else if (ch == 'O' || ch == 'o') {
                Console.WriteLine("The vowel is ou");
            } else if (ch == 'U' || ch == 'u') {
                Console.WriteLine("The vowel is iu");
            }
            else {
                Console.WriteLine("constant");
            }
        }
    }
}
