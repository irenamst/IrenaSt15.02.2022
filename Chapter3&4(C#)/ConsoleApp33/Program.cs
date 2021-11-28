using System;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 integer number.");
            int[] arr = new int [5];
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[" + i + "]= ");
                arr[i] = int.Parse(Console.ReadLine());

            }
            for(int i=0; i<arr.Length-1;i++)
            {
                for(int j=i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int a = arr[i];
                        arr[i] = arr[j];
                        arr[j] = a;
                    }
                }
            }

            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i] + ", ");
            }
        }
    }
}
