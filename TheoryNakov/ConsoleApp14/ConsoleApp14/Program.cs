using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers=
                from num in numbers
                where num%2==0
                select num;
            foreach(var item in evenNumbers)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
