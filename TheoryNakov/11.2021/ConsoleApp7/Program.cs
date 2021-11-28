using System;

namespace ConsoleApp7
{
    class Program
    {
        static (int result, int reminder) Divide(int x,int y)
        {
            int result = x / y;
            int reminder = x % y;
            return (result, reminder);
        }
        static void Main(string[] args)
        {
            Console.Write("x=");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y=");
            int y = int.Parse(Console.ReadLine());
            int result = Divide(x, y).result;
            int reminder = Divide(x, y).reminder;
            Console.WriteLine("result={0}, reminder={1}", result, reminder);
        }
    }
}
