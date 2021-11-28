using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of the rows: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of the cols: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements of the matrix: ");
            int[,] a = new int[n, m]; 
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<n; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }


            Console.Write("Enter the number of the rows: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of the cols: ");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements of the matrix: ");
            int[,] b = new int[k, l];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            bool equal=true;

            if(n==k && m == l)
            {
                for(int i=0; i < n; i++)
                {
                    for(int j=0; j<m; j++)
                    {
                        if (equal)
                        {
                            equal =(a[i, j] == b[i, j]);
                        }
                    }
                }
               
            }
            if (equal == true)
            {
                Console.WriteLine("The matrix are equal.");
            }
            else
            {
                Console.WriteLine("They aren't equal.");
            }
        }
    }
}
