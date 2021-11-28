using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Point
    {

    }
    public class Dog
    {
        public const string Species = "Canis Lupus Familiaris";
        private int age { get; set; }
        private string Name { get; set; }
        public Dog(int age,string name)
        {
            this.age = age;
            this.Name = name;
        }
        public void Breath()
        {

        }
        public void Bark()
        {
            Console.WriteLine("Wow-wow");
        }
    }
    internal class Program
    {
        public static void CalculateCircumference(int value)
        {

        }
        public static void PrintLogo()
        {

        }

        public static void CalcDistance(Point startPoint,Point endPoint)
        {

        }
        public static void DoSomething(int a,int b,int c)
        {

        }
        static void Main(string[] args)
        {
            DoSomething(1, 2, 3);
        }
    }
}
