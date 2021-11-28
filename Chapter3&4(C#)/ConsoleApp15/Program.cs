using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int intValue;
            bool success = Int32.TryParse(str, out intValue);
            if (success)
            {
                double sum = 1;
                for(int i = 1; i < intValue; i++)
                {
                    sum = sum +1.0/i;
                }
                Console.WriteLine("{0:0.000}", sum);
            }
            
        }
    }
}
