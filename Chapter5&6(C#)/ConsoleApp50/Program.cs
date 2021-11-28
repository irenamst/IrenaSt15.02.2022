using System;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a1 = 1; a1 <= 44; a1++) 
            { 
                for(int a2=a1+1; a2<=45; a2++)
                {
                    for(int a3 = a2 + 1; a3 <= 46; a3++)
                    {
                        for(int a4 = a3 + 1; a4 <= 47; a4++)
                        {
                            for(int a5 = a4 + 1; a5 <= 48; a5++)
                            {
                                for(int a6 = a5 + 1; a6 <= 49; a6++)
                                {
                                    Console.WriteLine(a1 + " " + a2 + " " + a3 + " " + a4 + " " + a5 + " " + a6);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
