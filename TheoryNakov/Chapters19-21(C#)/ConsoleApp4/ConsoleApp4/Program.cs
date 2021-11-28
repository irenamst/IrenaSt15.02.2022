using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static int Sum1(int[] numbers)
        {
            int sum = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6 };
            int sum =Sum1(myArray);
            Console.WriteLine("Hello");
            //if (Sum1(new int[] { 1, 2 }) != 3)    throw new Exception("1 + 2 != 3");
        }
    }
}
