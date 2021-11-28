using System;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            const int HEIGHT = 11;
            long[][] triangle = new long[HEIGHT+1][];
            for (int row = 0; row < HEIGHT; row++) {
                triangle[row] = new long[row + 1];
            }
            triangle[0][0] = 1;
            //Pascal's triangle
            for (int row = 0; row < HEIGHT-1; row++)
            {
                for (int col = 0; col <= row; col++) {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }
            //Print the Pascal's Triangle
            for (int row=0; row < HEIGHT; row++) {
                Console.Write("".PadLeft((HEIGHT-row)*2));
                for (int col = 0; col <= row; col++) {
                    Console.Write("{0,4}",triangle[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
