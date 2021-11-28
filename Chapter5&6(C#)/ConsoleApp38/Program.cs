using System;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];
            array[0] = 0;
            array[1] = 1;
            array[2] = 2;
            array[3] = 3;
            array[4] = 4;
            array[5] = 5;

            int[] myArray = new int[6];
            myArray[0] = 0;
            myArray[1] = 1;
            myArray[2] = 2;
            myArray[3] = 3;
            myArray[4] = 4;
            myArray[5] = 5;

            int[] matrix = { 0, 1, 2, 3, 4, 5 };

            string[] daysOfweek = { "Mon", "Tue", "Wen", "Thu", "Fri", "Sat", "Sun" };

            int[] arr = new int[6];
            for (int i=0; i<arr.Length; i++) {
                arr[i]=i;
            }
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }
    }
}
