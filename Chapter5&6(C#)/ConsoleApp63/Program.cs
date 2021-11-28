using System;

namespace ConsoleApp63
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            uint n = uint.Parse(Console.ReadLine());
            uint[,] matrix = new uint[n,n];
            for(uint i=0; i<n; i++)
            {
                for(uint j=0; j<n; j++)
                {
                    matrix[i, j] = i + j + 1;
                }
            }
            for(uint i=0; i<n; i++)
            {
                for(uint j=0; j<n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
