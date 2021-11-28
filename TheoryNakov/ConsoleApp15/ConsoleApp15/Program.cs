using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "cherry", "apple", "blueberry" };
            var wordsSortedByLength=
                from word in words
                orderby word.Length descending
                select word;
            foreach (var word in wordsSortedByLength)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();
        }
    }
}
