using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive number ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter the values of the array");
            for(int i=0; i<array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            bool symmetric = true;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] != array[array.Length - i - 1])
                {
                    symmetric = false;
                    break;
                }
            }
            if (symmetric)
            {
                Console.WriteLine("The array is symetric");
            }
            Console.WriteLine("The array is not symmetric.");
        }
    }
}
