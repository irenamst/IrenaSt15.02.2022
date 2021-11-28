using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
     
        class Program
        {
            static decimal Factorial(int n)
            {
                decimal result = 0;
                if (n == 0)
                {
                    result = 1;
                }
                else
                {
                    result = n * Factorial(n - 1);
                }
                return result;
            }
            static void Main(string[] args)
            {
                Console.Write("n=");
                int n = int.Parse(Console.ReadLine());
                decimal result = Factorial(n);
                Console.WriteLine(result);
            }
        }
    }

    