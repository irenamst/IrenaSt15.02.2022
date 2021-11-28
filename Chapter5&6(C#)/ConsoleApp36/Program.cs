using System;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2,3];
            for (int row = 0; row < matrix.GetLength(0); row++) {
                for(int col =0; col<matrix.GetLength(1); col++)
                matrix[row,col]=Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                    
                Console.WriteLine();
            }

        }
    }
}
