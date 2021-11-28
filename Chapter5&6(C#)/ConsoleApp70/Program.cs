using System;


namespace ConsoleApp70
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());           
            var rand = new Random();
            int[] arr = new int[n];

            for(int i=0; i< arr.Length; i++)
            {
                arr[i] = i+1;
            }
            int m = rand.Next(0, arr.Length);
            for(int i=0; i<m; i++)
            {
                int n1 = rand.Next(0, arr.Length - 1);
                int n2 = rand.Next(0, arr.Length - 1);
                while (n1 == n2)
                {
                    n2 = rand.Next(0, arr.Length - 1);
                }
                int t = arr[n1];
                arr[n1] = arr[n2];
                arr[n2] = t;
            }

            for (int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
