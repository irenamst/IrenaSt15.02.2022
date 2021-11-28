using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static long Sum(int[] elements)
        {
            int sum = 0;
            foreach (var element in elements)
            {
                sum=sum+element;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] elements = new int[10];
            elements[0] = 1;
            elements[1] = 2;
            elements[2] = 3;
            elements[3] = 4;
            elements[4] = 5;
            elements[5] = 6;
            elements[6] = 7;
            elements[7] = 8;
            elements[8] = 9;
            elements[9] = 10;
            if (Sum(new int[] { 1, 2 }) != 3)
            {
                throw new Exception("Има нещо.");
            }
            if (Sum(new int[] { 2 }) != 2)
            {
                throw new Exception("Има нещо.");
            }
            if (Sum(new int[] {}) != 0)
            {
                throw new Exception("Има нещо.");
            }
            if (Sum(new int[] {-2,-1 }) != -3)
            {
                throw new Exception("Има нещо.");
            }
            if (Sum(new int[] {200000000, 200000000 })!= 400000000)
            {
                throw new Exception("Има нещо.");
            }
            Console.WriteLine(Sum(elements));
        }
    }
}
