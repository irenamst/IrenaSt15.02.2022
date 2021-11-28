using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int k = 3;
            
            for(int i = 1; i <= k; i++)
            {
                for (int j = 1; j <= k; j++)
                {
                    Console.WriteLine("{0}{1}",i,j);
                }
            }
            for(int a1=1; a1 <= k; a1++)
            {
                for (int a2 = 1; a2 <= k; a2++)
                {
                    for (int a3 = 1; a3 <= k; a3++)
                    {
                        Console.WriteLine("{0} {1} {2}", a1, a2,a3);
                    }
                }
            }
            

        }
    }
}
