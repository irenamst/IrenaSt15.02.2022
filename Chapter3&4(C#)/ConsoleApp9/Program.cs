using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers: ");
            string str = Console.ReadLine();
            int intValue1;
            bool success = Int32.TryParse(str, out intValue1);
            str = Console.ReadLine();
            int intValue2;
            bool success2 = Int32.TryParse(str, out intValue2);
            str = Console.ReadLine();
            int intValue3;
            bool success3 = Int32.TryParse(str, out intValue3);
            str = Console.ReadLine();
            int intValue4;
            bool success4 = Int32.TryParse(str, out intValue4);
            str = Console.ReadLine();
            int intValue5;
            bool success5 = Int32.TryParse(str, out intValue5);
            if (success && success2 && success3 && success4 && success4 && success5)
            {
                int max = (intValue1 + intValue2 + Math.Abs(intValue1 - intValue2)) / 2;
                max = (max + intValue3 + Math.Abs(max - intValue3)) / 2;
                max = (max + intValue4 + Math.Abs(max - intValue4)) / 2;
                max = (max + intValue5 + Math.Abs(max - intValue5)) / 2;
                Console.WriteLine("Max:" + max);
            }
            else
            {
                Console.WriteLine("Invalid Value.");
            }
        }
    }
}
