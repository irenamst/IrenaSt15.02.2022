using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.AddRange(Enumerable.Range(1, 100000));
            DateTime startTime = DateTime.Now;  
            for(int i = 0; i < 10000; i++)
            {
                var elements = list.Where(e => e > 20000);
            }
            Console.WriteLine("No execution:\t{0}", DateTime.Now - startTime);
            startTime = DateTime.Now;
            for(int i = 0; i < 10000; i++)
            {
                var element = list.Where(e => e > 20000).First();
            }
            Console.WriteLine("Execution: \t{0}",DateTime.Now - startTime);
        }
    }
}
