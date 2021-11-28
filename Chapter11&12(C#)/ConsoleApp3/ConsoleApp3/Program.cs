using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.List<int> ints = new System.Collections.Generic.List<int>();
            System.Collections.Generic.List<double> doubles = new System.Collections.Generic.List<double>();
            while (true)
            {
                int intResult;
                double doubleResult;
                Console.WriteLine("Enter an int or double");
                string input=Console.ReadLine();
                if(int.TryParse(input, out intResult))
                {
                    ints.Add(intResult);
                }else if(double.TryParse(input, out doubleResult))
                {
                    doubles.Add(doubleResult);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("You entered {0} units",ints.Count);
            foreach(var i in ints)
            {
                Console.WriteLine(" "+i);
            }
            Console.WriteLine();
            Console.WriteLine("You entered {0} units",doubles.Count);
            foreach(var d in doubles)
            {
                Console.WriteLine(" "+d);
            }
            Console.WriteLine();

        }
    }
}
