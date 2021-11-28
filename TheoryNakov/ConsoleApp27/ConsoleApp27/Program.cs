using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Sort10000Numbers
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10000];
            Random rnd = new Random();
            for(int i=0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(2 * numbers.Length);
            }
            SortNumbers(numbers);
            PrintNumbers(numbers);
        }
        static void SortNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                    int oldNumber = numbers[i];
                    numbers[i] = numbers[minIndex];
                    numbers[minIndex] = oldNumber;
                }
            }
        }
        static void PrintNumbers(params int[] numbers) =>
                Console.WriteLine($"[{String.Join(", ", numbers)}]");

    }
}
