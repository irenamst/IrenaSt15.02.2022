using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elements = { 1, 2, 3, 4, 5 };
            Console.WriteLine(Sum(elements));
            double a = 3;
            double b = 4;
            double c = 5;
            Console.WriteLine(CalcTriangleArea(a, b, c));
        }
        static long Sum(int[] elements)
        {
            long sum = 0;
            foreach(int element in elements)
            {
                sum = sum + element;
            }
            return sum;
        }
        static double CalcTriangleArea(double a,double b,double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be posible.");
            }
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
    }
}
