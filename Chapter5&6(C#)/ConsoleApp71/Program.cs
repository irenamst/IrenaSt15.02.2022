using System;

namespace ConsoleApp71
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            uint a = uint.Parse(Console.ReadLine());
            Console.Write("b= ");
            uint b = uint.Parse(Console.ReadLine());
            long m = Math.Abs(a * b);
            uint r;
            if (a < b)
            {
                uint t = a;
                a = b;
                b = t;

            }
                do
                {
                r = a % b;
                a = b;
                b = r;
               
                } while (r != 0);

            Console.WriteLine("NOD=" + a);
           
            long v = m / a;
            Console.WriteLine("NOK="+v);
            
            
        }
    }
}
