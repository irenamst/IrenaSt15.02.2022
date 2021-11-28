using System;

namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            string direction= "right";
            int[,] arr = new int[n,n];
            int m = 1;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        arr[i, j] = i+j +m;
                    }
                    m=m+3;
                }
            

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}",arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            int d = 0;
            int r = 0;
            int e = n;
            int s = -1;
                    switch (direction)
                    {
                        case "right":
                            e--;
                            while(r < e+1)
                            {
                                Console.Write("{0,3}",arr[d, r]);
                                r++;
                            }
                            d++;
                            direction ="down";
                            Console.WriteLine();
                            break;
                            
                        case "down":
                            while(d < e)
                            {
                                
                                Console.Write(arr[d, r] + " ");
                                d++;
                            }
                            r--;
                            direction = "left";
                            break;
                        case "left":
                            //s++;
                            for (; r >= s;)
                            {
                                
                                Console.Write(arr[d,r] + " ");
                                r--;
                            }
                            d--;
                            direction = "up";
                            break;
                        case "up":
                            for (; d > s;)
                            {
                                
                                Console.Write(arr[r, d] + " ");
                            d--;
                            }
                            r++;
                            direction = "rigth";
                            break;
                    }

            
        }
    }
}
