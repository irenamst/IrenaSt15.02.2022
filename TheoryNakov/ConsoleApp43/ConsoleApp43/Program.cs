using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            bool condition1 = false;
            bool condition2 = false;
            int value=0;
            if (condition1)
            {
                if (condition2)
                {
                    value = 1;
                }
                else
                {
                    value = 2;
                }
            }
            Console.WriteLine(value);
        }
    }
}
