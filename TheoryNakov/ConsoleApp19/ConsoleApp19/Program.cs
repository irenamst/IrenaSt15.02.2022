using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = new List<int>();
            DateTime startTime = DateTime.Now;
            firstList.AddRange(Enumerable.Range(1, 50000000));
            Console.WriteLine("Ext.method:\t {0}",DateTime.Now-startTime);

            List<int> secondList=new List<int>();
            startTime = DateTime.Now;
            for (int i = 0; i < 50000000; i++)
                secondList.Add(i);
            Console.WriteLine("For loop: \t{0}", DateTime.Now - startTime);
        }
    }
}
