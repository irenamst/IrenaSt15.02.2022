using System;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][,] threeDimentionalMasiv = new int[3][,];
            threeDimentionalMasiv[0] = new int[2, 2];
            threeDimentionalMasiv[1] = new int[3, 3];
            threeDimentionalMasiv[2] = new int[4, 4];

            int[][,] ordinaryMasiv = new int[2][,];
            ordinaryMasiv[0] = new int[,] { {1,2,3}, {4,5,6} };
            ordinaryMasiv[1] = new int[,] { {1,2}, {3,4} };
        }
    }
}
