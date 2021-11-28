using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            string str=Console.ReadLine();
            int n,suma=0,a;
            bool success = Int32.TryParse(str, out n);
            if (success)
            {
                for (int i = 0; i < n; i++) {
                    str = Console.ReadLine();
                    success = Int32.TryParse(str, out a);
                    if (success)
                    {
                        suma += a;
                    }
                    else
                    {
                        break;
                    }
                }
                if (success)
                {
                    Console.WriteLine("Summa:"+suma);
                }
            }
        }
    }
}
