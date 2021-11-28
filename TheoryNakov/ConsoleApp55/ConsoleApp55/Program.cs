using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace ConsoleApp55
{
    internal class Program
    {
        static long Sum(int[] numbers)
        {
            long sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            
            DateTime startTime = DateTime.Now;

            int[] numbers = new int[10000000];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 5;
            }
            if (Sum(numbers) != 50000000)
                throw new Exception("5 + … (10000000 times) != 50000000");
            DateTime endTime = DateTime.Now;
            
            Console.WriteLine(new TimeSpan(0, 0, 1));
           
        }
    }
}
