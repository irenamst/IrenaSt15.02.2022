using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int intValue;
            bool parseSuccess = Int32.TryParse(str, out intValue);
            Console.WriteLine(parseSuccess ? "The square of the number is: "+intValue*intValue+"." : "Invalid value");
        }
    }
}
