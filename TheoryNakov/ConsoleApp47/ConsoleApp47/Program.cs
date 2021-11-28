using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count;
            int[] numbers = new int[100];
            for(int i=0; i<numbers.Length; i++)
            {
                numbers[i] = 0;
            }
            count = 0;
            for(int i=0;i<numbers.Length/2; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
            }
            for(int i=0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3==0)
                {
                    count++;
                }
            }
           Console.WriteLine(count);
        }
    }
}
