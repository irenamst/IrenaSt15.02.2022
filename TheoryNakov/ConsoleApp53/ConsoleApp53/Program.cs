using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    internal class Program
    {
        private static  int Max(int a, int b, int c, int d)
        {
            if (a < b)
            {
                if (b < c)
                    {
                    if (c < d)
                    {
                        return d;
                    }
                    else
                    {
                        return c;
                    }
                }
        else if (b > d)
                {
                    return b;
                }
                else
                {
                    return d;
                }
            }
            else if (a < c)
            {
                if (c < d)
                {
                    return d;
                }
                else
                {
                    return c;
                }
            }
            else if (a > d)
            {
                return a;
            }
            else
            {
                return d;
            }
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine(Max(a, b, c, d));
        }
    }
}
