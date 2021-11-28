using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.Write("Output: ");
            for(int index=0; index < array.Length; index++)
            {
                array[index] = 2 * array[index];
                Console.Write(array[index] + ", ");
            }
        }
    }
}
