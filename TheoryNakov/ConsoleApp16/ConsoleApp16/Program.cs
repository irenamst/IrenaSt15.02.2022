using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 10, 11, 12, 13 };
            int divisor = 5;
            var numberGroups =
            from number in numbers
            group number by number % divisor into group1
            select new { Remainder = group1.Key, Numbers = group1 };
            
            foreach(var group1 in numberGroups)
            {
                Console.WriteLine("Numbers with a remainder of {0} when divided by {1}:", group1.Remainder,divisor);
                foreach(var number in group1.Numbers)
                {
                    Console.WriteLine(number);
                }
            }


        }
    }
}
