using System;

namespace ConsoleApp11
{
    class PrintLogo
    {
        static void PrintLogo()
        {
            Console.WriteLine("Microsoft");
            Console.WriteLine("www.microsoft.com");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PrintLogo();
            PrintCompanyInformation();
        }
        static void PrintCompanyInformation()
        {
            PrintLogo();
            Console.WriteLine("Address: One, Microsoft Way");
        }
    }
}
