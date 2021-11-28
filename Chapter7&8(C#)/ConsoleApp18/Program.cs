using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            float sum = 0f;
            for(int i=0; i < 1000; i++)
            {
                sum+=0.1f;
            }
            Console.WriteLine("Sum={0}",sum);
            Console.WriteLine("Sum={0:r}", sum);
            double suma = 0.0d;
            for(int i = 1; i <=10; i++)
            {
                suma += 0.1d;
            }
            Console.WriteLine("Sum={0}", suma);
            Console.WriteLine("Sum={0:r}", suma);
            float sumata = 0.0f;
            for(int i=1; i <= 10; i++)
            {
                sumata += 0.1f;
            }
            Console.WriteLine("Sum={0}", sumata);
            Console.WriteLine("Sum={0:r}", sumata);
        }
    }
}
