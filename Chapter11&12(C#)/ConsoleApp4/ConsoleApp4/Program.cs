using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            List<double> doubles = new List<double>();
            while (true)
            {
                int intResult;
                double doubleResult;
                Console.WriteLine("Enter int or double");
                string input = Console.ReadLine();

                if (int.TryParse(input, out intResult))
                {
                    ints.Add(intResult);
                }
                else if (double.TryParse(input, out doubleResult))
                {
                    doubles.Add(doubleResult);
                }
                else
                {
                    break;
                }
            }
                Console.WriteLine("You entered {0} integers",ints.Count);
                foreach(var i in ints)
                {
                    Console.Write("{0} ",i);
                }
                Console.WriteLine();
                Console.WriteLine("You entered {0} doubles",doubles.Count);
                foreach(var d in doubles)
                {
                    Console.Write("{0} ",d);
                }
                Console.WriteLine();
            
        }
    }
}
