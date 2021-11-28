using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class GeometryUnits
    {
        public const double Pi = 3.14159;
        public const double r = 3;
        public static double CalcCirclePerimeter(double r) 
        { double P = 2 * Pi * r;
            return P;
        }
        public static double CalcCircleArea(double r)
        {
            double S = Pi * r * r;
            return S;
        }
        public static double CalcElipsaArea(double axis1, double axis2)
        {
            double area = Pi * axis1 * axis2;
            return area;
        }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
