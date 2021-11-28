using System;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a x^2 + b x + c =0");
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            double c = double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
            if (d == 0) {
                double x = (-b) / (2.0 * a);
                Console.WriteLine("x1=x2= {0}",x);
            }else if (d > 0)
            {
                double x1 = (-b + Math.Sqrt(d)) / (2.0 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2.0 * a);
                Console.WriteLine("x1= {0} and x2= {1}",x1,x2);
            }
            else
            {
                Console.WriteLine("No real roots");
            }
        }
    }
}
