using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static long Sum(int[] elements)
        {
            int sum = 0;
            for(int i=0; i<elements.Length; i++)
            {
                sum = sum + elements[i];
                elements[i] = 0;
            }
            return sum;
        }
        double CalcTriangleArea(double a,double b,double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Страните са положителни числа.");
            }
            double s = (a + b + c) / 2;
            double area=s*(s-a)*(s-b)*(s-c);
            return area;
        }
        static void Main(string[] args)
        {
        }
    }
}
