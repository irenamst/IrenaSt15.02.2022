using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    internal class Program
    {
        public static int Max(int a,int b)
        {
            if (a < b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        public static int Max(int a,int b,int c)
        {
            if (a < b)
            {
                return Max(a, b);
            }
            else
            {
                return Max(a, c);
            }
        }
        public static int Max(int a,int b,int c,int d)
        {
            if (a < b)
            {
                return Max(b, c, d);
            }
            else
            {
                return Max(a, c, d);
            }
        }
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            Console.WriteLine(Max(a,b,c,d));
        }
    }
}
