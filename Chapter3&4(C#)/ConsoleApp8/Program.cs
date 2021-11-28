using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers");
            string str = Console.ReadLine();
            int intValue1;
            bool parseSuccess1 = Int32.TryParse(str, out intValue1);
            int intValue2;
            str = Console.ReadLine();
            bool parseSuccess2 = Int32.TryParse(str, out intValue2);
            str = Console.ReadLine();
            int intValue3;
            bool parseSuccess3 = Int32.TryParse(str, out intValue3);
            str = Console.ReadLine();
            int intValue4;
            bool parseSuccess4 = Int32.TryParse(str, out intValue4);
            str = Console.ReadLine();
            int intValue5;
            bool parseSuccess5 = Int32.TryParse(str, out intValue5);
            if (parseSuccess1 && parseSuccess2 && parseSuccess3)
            {
                int sum = intValue1 + intValue2 + intValue3 + intValue4+intValue5;
                Console.WriteLine("sum=" + sum);
            }
            else
            {
                Console.WriteLine("Invalid value.");
            }
        }
    }
}
