using System;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intArray = {
            {1,2,3,4 },
            {5,6,7,8 },
            {9,10,11,12 }
            };
            //Console.WriteLine(intArray.Length);
            float[,] floatArray = {
            {1.1f,1.2f,1.3f,1.4f,1.5f },
            {2.1f,2.2f,2.3f,2.4f,2.5f },
            {3.1f,3.2f,3.3f,3.4f,3.5f },
            {4.1f,4.2f,4.3f,4.4f,4.5f }
            };
            for (int i =0; i<3; i++) {
                for(int j=0;j<4;j++){
                    Console.Write(intArray[i,j]+" " );
                }
                Console.WriteLine();
            }
        }
    }
}
