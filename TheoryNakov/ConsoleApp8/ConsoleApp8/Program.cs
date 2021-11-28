using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumber=numbers.FindAll(x=>(x%2)==0);
            foreach(var num in evenNumber)
            {
                Console.Write($"{ num } ");
            }
            Console.WriteLine();
        }
    }
}
