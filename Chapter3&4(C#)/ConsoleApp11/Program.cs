using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string str = Console.ReadLine();
            int n;
            bool success = Int32.TryParse(str, out n);
            if (success)
            {
                for(int i=1; i<=n; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
