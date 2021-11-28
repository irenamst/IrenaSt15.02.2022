using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n;
            bool success =Int32.TryParse(str, out n);
            if (success)
            {
                double currentSum = 1;
                double oldSum = currentSum;
                double[] a =new double[n];
                for (int i=1; i <= n; i++)
                {
                    if (Math.Abs(oldSum - currentSum)<0.001)
                    {
                    oldSum = currentSum;
                  //a[i] = 1 / i;
                    //currentSum = oldSum + a[i];
                    
                    //Console.WriteLine(currentSum);
                    }
                    
                }
                Console.WriteLine("{0:0.000}" ,currentSum);

            }
        }
    }
}
