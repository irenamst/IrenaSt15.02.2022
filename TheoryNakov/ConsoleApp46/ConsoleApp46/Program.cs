using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    internal class Program
    {
        static int Archive()
        {
            int result = 0;
            return result;
        }
        static void Main(string[] args)
        {
            if (false)
            {
                int result = 0;
                Console.WriteLine(result);
            }
            
            Console.WriteLine(Archive());

            int[] data = new int[] { 1, 2, 3 };
            int sum = 0;
            for(int i=0; i < data.Length; i++)
            {
                sum = sum+data[i];
            }
            Console.WriteLine(sum);
        }
    }
}
