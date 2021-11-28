using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            for(int i=0; i<numbers.Length; i++)
            {
                numbers[i] = i;
            }
            int count = 0;
            for(int j=0; j<numbers.Length; j++)
            {
                if (numbers[j] % 3 == 0)
                {
                    count++;
                }
                
            }
            Console.WriteLine(count);
        }
    }
}
