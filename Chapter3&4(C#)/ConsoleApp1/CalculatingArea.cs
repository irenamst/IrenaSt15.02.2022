using System;

namespace ConsoleApp1
{
    class CalculatingArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the area "+"of rectangle or triagle");
            Console.WriteLine("Enter the a and b for the rectangle" + "and the a and h for the triangle.");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 1 for rectangle" + " and 2 for the triangle");
            int choice = int.Parse(Console.ReadLine());
            double Area = (double)a * b / choice;
            Console.WriteLine(Area);
        }
    }
}
