using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight = 700;
            Console.WriteLine(weight > 500);

            char gender = 'm';
            Console.WriteLine(gender>'f');

            double colorWaveLength=1.630;
            Console.WriteLine(colorWaveLength>1.621);

            int a = 5;
            int b = 7;
            bool condition =(b>a)&&(a*b>a+b);
            Console.WriteLine(condition);
        }
    }
}
