using System;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];
            int n = array.Length;
            for (int i = 0; i < n; i++) {
                array[i]=int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            int[] newArray = new int[n];
            for (int i =0; i<n; i++) {
                newArray[i] = array[n - 1 - i];
            }
            Console.WriteLine();
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(newArray[i] + " ");
            }
        }
    }
}
