using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var elements = new[]
            {
                new{X=3,Y=5},
                new{X=1,Y=2},
                new{X=0,Y=7}
            };
            foreach(var element in elements)
            {
                Console.WriteLine(element.ToString());
            }
        }
    }
}
