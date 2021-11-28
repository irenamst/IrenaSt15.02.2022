using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numbers= new LinkedList<int>(new int[] { 3,2,6,1,2});
            while(numbers.Count > 0)
            {
                Console.Write("{");
                foreach (int n in numbers)
                {
                    Console.Write(n + " ");
                }
                Console.Write("}-> ");
                int m = int.MaxValue;
                foreach (int n in numbers)
                {
                    if (n <= m) { m = n; }
                }
                numbers.Remove(m);
                Console.Write(m+" ");
                Console.WriteLine();    
            }
        }
    }
}
