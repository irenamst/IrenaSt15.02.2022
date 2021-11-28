using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_21_Quality_Code
{
    class Program
    {
        public static void Main(String[] args)
        {
            bool EOF = true;
            while (!EOF)
            {
                Console.WriteLine("Hello!");
            }
            
            Point point1 = new Point();
            Point point2 = new Point();
            CalcDistance(point1, point1);
            DoSomething(1, 2, 3);
        }
        public double CalculateCircumference(int radius)
        {
            return 2 * Math.PI * radius;
        }
        public static void PrintLogo()
        {

        }
        public static void CalcDistance(Point startPoint,Point endPoint) {  
        
        }
        public static void DoSomething(int x, int y, int z)
        {

        }
        
    }
    public class IndentationExample
    {
        public static void DoSth1()
        {

        }
        public static void DoSth2()
        {
            
        }
    }
    public class Point
    {
        
    }
}
