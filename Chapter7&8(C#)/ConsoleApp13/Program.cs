using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Rows: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Cols: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter masive with letters: ");

            char[,] a = new char[n, m];
            for(int i=0; i < n; i++)
            {
                for(int j=0; j < m; j++)
                {
                    a[i, j] = char.Parse(Console.ReadLine());
                }
            }

            Console.Write("Rows: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Cols: ");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter masive with letters:");

            char[,] b = new char[k, l];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    b[i, j] = char.Parse(Console.ReadLine());
                }
            }
            bool first = true, second = true;
            if(n==k && m == l)
            {
                for (int i = 0; i < n; i++)
                {
                    for(int j=0; j < m; j++)
                    {

                        if (first)
                        {
                            first = (a[i, j] >= b[i, j]) ? true : false;
                        }
                        if (second)
                        {
                            second = (b[i, j] >= a[i, j]) ? true : false;
                        }
                        
                    }
                }
            }
            if (first)
            {
                Console.Write("The first is the first.");
            }
            else if (second)
            {
                Console.Write("The second is the first.");
            }
            else
            {
                Console.Write("The first is not the best.");
            }
            
        }
    }
}
