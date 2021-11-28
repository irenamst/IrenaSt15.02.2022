using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int codeRead = 0;
            do
            {
                codeRead = Console.Read();
                if (codeRead != 0)
                    Console.Write((char)codeRead);
            } while (codeRead != 10);
        }
    }
}
