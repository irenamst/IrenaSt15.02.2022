using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        private static int Max(int a,int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public static int Max(int a, int b, int c)
        {
            if(Max(a,b) < c)
            {
                return c;
            }
            else
            {
                return Max(a, b);
            }
        }
        public static int Max(int a,int b,int c,int d)
        {
            if (Max(a, b, c) < d)
            {
                return d;
            }
            else
            {
                return Max(a, b, c);
            }
        }
        static void Main(string[] args)
        {
            int a = 2;
            int b = 1;
            int c = 4;
            int d = 3;
            int max = Max(a, b, c,d);
            Console.WriteLine(max);

        }
    }
}
