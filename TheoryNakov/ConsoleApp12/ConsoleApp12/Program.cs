using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 20, 1, 4, 8, 9, 44 };
            //Process each argument with code statements
            var evenNumbers = numbers.FindAll((i) =>
            { 
                Console.WriteLine("Value of i is: {0}",i);
                return (i%2==0);
            });

        }
    }
}
