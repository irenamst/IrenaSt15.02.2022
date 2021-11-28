using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long Sum(int[] elements)
            {
                int sum = 0;
                foreach(int element in elements)
                {
                    sum = sum + element;
                }
                return sum;
            }
            double CalcTriangleArea(double a,double b,double c)
            {
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    throw new ArgumentException("Невалидни данни.");
                }
                double s = (a + b + c) / 2;
                double area=Math.Sqrt(s*(s-a)*(s-b)*(s-c));
                return area;
            }
        }
    }
}
