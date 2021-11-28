using System;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] massaive = new int[20];
            for(int i =0; i<massaive.Length; i++)
            {

                massaive[i] = i * 5;
            };
            for (int i = 0; i < massaive.Length; i++) {
                Console.Write(massaive[i] + " ");
            };
            Console.WriteLine();
        }
    }
}
