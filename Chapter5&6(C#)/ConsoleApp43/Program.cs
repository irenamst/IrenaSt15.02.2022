using System;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i=0; i<array.Length;i++) {
                array[i] =int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i=0; i<array.Length; i++) {
                if (array[i] % 2 == 0 && array[i] > 0) {
                    sum += array[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
