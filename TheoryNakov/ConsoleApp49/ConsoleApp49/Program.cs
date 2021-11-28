using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    internal class Program
    {
        static int FindMin(int index)
        {
            int min = int.MaxValue;
            int result = min;
            for (int i = 0; i <= index; i++)
            {
                if (i < min)
                {
                    min = i;
                }
                result = min;
            }
            return result;
        }
        static int FindMax(int index)
        {
            int max = int.MinValue;
            int result = max;
            for (int i = 0; i <= index; i++)
            {
                if (i > max)
                {
                    max = i;
                }
                result = max;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] xCoord=new int[4] {1,2,3,4 };
            int[] yCoord=new int[4] {1,2,3,4 };
            int[][] matrix = new int[4][];
            matrix[0] = new int[4] {10,11,12,13};
            matrix[1] = new int[4] {14,15,16,17};
            matrix[2] = new int[4] {18,19,20,21};
            matrix[3] = new int[4] {22,23,24,25};

            for (int i = 0; i < xCoord.Length; i++)
            {
                for(int j = 0; j < yCoord.Length; j++)
                {
                    int minStartIndex = FindMin(i) + 1;
                    int maxStartIndex = FindMax(i) + 1;
                    try
                    {

                        int minXCoord = xCoord[minStartIndex];
                        int maxXCoord = xCoord[maxStartIndex];
                        int minYCoord = yCoord[minStartIndex];
                        int maxYCoord = yCoord[maxStartIndex];
                        Console.WriteLine(minXCoord + " " + maxXCoord + " " + minYCoord + " " + maxYCoord);


                        matrix[i][j] = matrix[maxXCoord][minYCoord] * matrix[maxYCoord][minXCoord];
                    }catch(IndexOutOfRangeException e)                    {

                        Console.WriteLine(e.Message);
                        Console.WriteLine("Излиза извън границите");
                        }
                }
                Console.WriteLine();
            }

            for(int i=0; i<matrix.Length; i++)
            {
                for(int j=0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
