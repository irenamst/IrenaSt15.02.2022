using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    internal class GeometryUtils
    {
        public const double PI = 3.14159206;
        public static double CalcCircleArea(double radius)
        {
            double area = PI * radius*radius;
            return area;
        }

        public static double CalcCirclePerimeter(double radius)
        {
            double perimeter=2*PI*radius;
            return perimeter;
        }
        public static double CalcElipseArea(double axes1,double axes2)
        {
            double area= PI * axes1*axes2;
            return area;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CalcCircleArea(3));
            Console.WriteLine(CalcCirclePerimeter(3));
            Console.WriteLine(CalcElipseArea(3,4));
        }
    }
}
