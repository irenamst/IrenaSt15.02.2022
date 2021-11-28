using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp64
{
    internal class Program
    {
        static long Sum(int[] numbers)
        {
            long sum= 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum= sum + numbers[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            DateTime startTime = DateTime.Now;
            int[] numbers = new int[10000000];
            for(int i=0; i<numbers.Length; i++)
            {
                numbers[i] = 5;
            }
            if (Sum(numbers) != 50000000)
            {
                throw new Exception("5 +...(10 000 000 times)!=50 000 000");
            }
            DateTime endTime = DateTime.Now;
            TimeSpan difference = endTime - startTime;
            TimeSpan timeSpan = new TimeSpan(0, 0, 1);
            if (Equals(difference, timeSpan))
            {
                throw new Exception("Performance issue: summing 10000000" + "numbers takes more than 1 second.");
            }
        }
    }
}
