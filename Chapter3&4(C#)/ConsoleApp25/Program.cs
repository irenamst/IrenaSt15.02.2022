using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'X';
            if (ch == 'A' || ch == 'a')
            {
                Console.WriteLine("ei");
            } else if (ch == 'E' || ch == 'e')
            {
                Console.WriteLine("e:");
            } else if (ch == 'I' || ch == 'i')
            {
                Console.WriteLine("ai");
            } else if (ch == 'O' || ch == 'o')
            {
                Console.WriteLine("ou");
            }else if(ch == 'U' || ch == 'u')
            {
                Console.WriteLine("u:");
            }else if(ch == 'Y' || ch == 'y')
            {
                Console.WriteLine("wai");
            }
            else
            {
                Console.WriteLine("This character is not a vowel.");
            }


        }
    }
}
