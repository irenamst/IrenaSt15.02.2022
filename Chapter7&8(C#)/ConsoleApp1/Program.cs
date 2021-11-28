using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int length = array.Length;
            int[] reversed = new int[length];
            for(int index=0; index<length; index++)
            {
                reversed[index] = length - index;
                
            }
            for(int index=0; index<length; index++)
            {
                Console.Write(reversed[index]+" ");
            }

        }
    }
}
