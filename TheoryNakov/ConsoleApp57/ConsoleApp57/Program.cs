using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    internal class Program
    {
        public static int Max(int a,int b,int c,int d)
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
                }else if (b < d)
                {
                    return b;
                }
                else
                {
                    return d;
                }
            }else if (a < c)
            {
                if (c < d)
                {
                    return d;
                }
                else
                {
                    return c;
                }
            }else if (a > d)
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
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;

            Console.WriteLine(Max(1, 2, 3, 4));
            Console.WriteLine(Max(a, b, c, d));
        }
    }
}
