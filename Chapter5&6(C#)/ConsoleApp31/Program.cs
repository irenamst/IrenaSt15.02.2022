using System;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                for(int j=0; j<i; j++)
                {
                    Console.Write(j+1 + " ");
                }
                Console.WriteLine(Environment.NewLine);
                
            }
        }
    }
}
