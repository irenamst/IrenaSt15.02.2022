using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0)
            {
                Console.WriteLine("+");
            }
            if ((a < 0 && b < 0 && c > 0) || (a > 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c < 0))
            {
                Console.WriteLine("+");
            }
            if ((a < 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c > 0) || (a > 0 && b > 0 && c < 0))
            {
                Console.WriteLine("-");
            }
            if(a < 0 && b < 0 && c < 0)
            {
                Console.WriteLine("-");
            }
            
        }
    }
}
